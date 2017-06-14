using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Globalization;
using System.Runtime.Remoting;

namespace Hospital
{
    public partial class procedure : Form
    {
        public procedure()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string folderName;
        pub p = new pub();

        
        private void procedure_Load(object sender, EventArgs e)
        {
            saveChanges.Visible = false;
            infoSaveDirTSM.Text = "Директория сохранения отчетов: " + Properties.Settings.Default.saveDir;
            this.AcceptButton = updateReports;
        }

        //buttons
        private void updateReports_Click(object sender, EventArgs e)
        {
            procedureDialog procd = new procedureDialog();
            procd.Owner = this;
            procd.ShowDialog();
        }
        // meth - overwriting
        private void saveReports_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.saveDir == "")
            {
                MessageBox.Show("Укажите директорию сохранения отчетов!",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                overwriting();
                GC.Collect();
            }
        }

        //meth - copyDT and sqlbulk
        private void saveChanges_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView7.Rows.Count; i++)
            {
                if (dataGridView7.Rows[i].Cells[14].Value.ToString() == "0")
                {
                    sum++;
                }
            }
            if (sum > 0)
            {
                MessageBox.Show("В таблице остались ошибки!" + Environment.NewLine + "Количество ошибок: " + sum, "Предупреждение!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                saveChange();
            }
        }

        //TSM
        private void mainWinTSM_Click(object sender, EventArgs e)
        {
            procedure_FormClosing(sender, (e as FormClosingEventArgs));
        }

        private void saveReportsTSM_Click(object sender, EventArgs e)
        {
            saveReports_Click(sender, e);
        }

        private void openDirTSM_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.saveDir == "")
            {
                MessageBox.Show("Укажите директорию сохранения отчетов!",
                   "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    System.Diagnostics.Process.Start(folderName);
                }
                catch (Exception)
                {
                    System.Diagnostics.Process.Start(Properties.Settings.Default.saveDir);
                }
            }
        }

        private void aboutTheProgramTSM_Click(object sender, EventArgs e)
        {
            aboutTheProgram atp = new aboutTheProgram();
            atp.Show();
        }

        private void exitTSM_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Properties.Settings.Default.Save();
            System.Windows.Forms.Application.Exit();
        }

        private void saveDirTSM_Click(object sender, EventArgs e)
        {
            main main = new main();
            main.folderBrowserDialog1.ShowDialog();
            Properties.Settings.Default.saveDir = main.folderBrowserDialog1.SelectedPath;
            infoSaveDirTSM.Text = "Директория сохранения отчетов: " + Properties.Settings.Default.saveDir;
        }

        //methods
        private void printExcel(Microsoft.Office.Interop.Excel.Application ExcelApp, Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook, Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet)
        {
            ExcelApp.DisplayAlerts = false;
            ExcelWorkBook.PrintOut(Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            
            GC.Collect();
        }
        private void excelSave(DataGridView dgv, TabPage tabp)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            Microsoft.Office.Interop.Excel.Range Merge;
            Microsoft.Office.Interop.Excel.Range Border;
            Microsoft.Office.Interop.Excel.Range firstColumn;

            //Создание книги и листа.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            //Статическая информация
            ExcelWorkSheet.Cells[1, 1] = "Данные реестров мед помощи";
            ExcelWorkSheet.Cells[2, 1] = DateTime.Now.ToShortDateString().ToString();
            ExcelWorkSheet.Cells[3, 1] = "За период с 01." + DateTime.ParseExact(infoTableTSM.Text.Substring(0, infoTableTSM.Text.Length - 4),
                "MMMM", CultureInfo.CurrentCulture).Month + "." +
                infoTableTSM.Text.Substring(infoTableTSM.Text.Length - 4) + " по " +
                //Опрделение количества дней в месяце.
                DateTime.DaysInMonth(Convert.ToInt32(infoTableTSM.Text.Substring(infoTableTSM.Text.Length - 4)),
                DateTime.ParseExact(infoTableTSM.Text.Substring(0, infoTableTSM.Text.Length - 4), "MMMM", CultureInfo.CurrentCulture).Month) + "." +
                //Форматирование месяца.
                DateTime.ParseExact(infoTableTSM.Text.Substring(0, infoTableTSM.Text.Length - 4), "MMMM", CultureInfo.CurrentCulture).Month + "." +
                infoTableTSM.Text.Substring(infoTableTSM.Text.Length - 4);
            ExcelWorkSheet.Cells[4, 1] = "МО: 1637 Полевская ЦГБ";

            //Объединение ячеек.
            ExcelWorkSheet.Range[ExcelWorkSheet.Cells[5, 1], ExcelWorkSheet.Cells[5, dgv.Columns.Count]].Merge(Type.Missing);
            ExcelWorkSheet.Cells[5, 1] = tabp.Text;
            //Выравнивание ячейки по центру.
            Merge = ExcelWorkSheet.get_Range("A5", "A5");
            Merge.HorizontalAlignment = Constants.xlCenter;
            Merge.VerticalAlignment = Constants.xlCenter;

            //Формирование границ.
            Border = ExcelWorkSheet.get_Range("5:" + (dgv.Rows.Count + 5), Type.Missing);
            Border = ExcelWorkSheet.Range[ExcelWorkSheet.Cells[5, 1], ExcelWorkSheet.Cells[(dgv.Rows.Count + 6), dgv.Columns.Count]];
            Border.Borders.ColorIndex = 0; 

            //Выгрузка данных.
            for (int i = 1; i < dgv.ColumnCount + 1; i++)
            {
                ExcelWorkSheet.Cells[6, i] = dgv.Columns[i - 1].HeaderText;
            } 

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value.ToString() == "" && tabp.Text == "Диспансеризация")
                    {
                        ExcelApp.Cells[i + 7, j + 1] = 0;
                    }
                    else ExcelApp.Cells[i + 7, j + 1] = dgv.Rows[i].Cells[j].Value;
                }
            }
            //Ширина по размеру текста.
            ExcelApp.Columns.AutoFit();
            //Ширина первой колонки(начиная с 6ячейки)
            firstColumn = ExcelWorkSheet.Cells[6, 1];
            // ВЕРНУТЬ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //if(tabp.Text == "Диспансеризация")
            //{
            //    ExcelApp.Columns.AutoFit();
            //}else firstColumn.Columns.AutoFit();
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            // УДАЛИТЬ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (tabp.Text == "Диспансеризация")
            {
                firstColumn = ExcelWorkSheet.Cells[7, 1];
                firstColumn.Columns.AutoFit();
            }
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            else firstColumn.Columns.AutoFit();
            ExcelApp.DisplayAlerts = false;
            //Автосохранение и присвоение имени отчета.
            if(button1.Enabled == false)
            {
                printExcel(ExcelApp, ExcelWorkBook, ExcelWorkSheet);
            }
            ExcelWorkBook.Close(true, folderName + tabp.Text, Type.Missing);
            //Печать ДОДЕЛАТЬ
           
        }
        private void copyToDT()
        {         
            //Копирование данных из DGV в dataTable.
            System.Data.DataTable dt = ds.Tables.Add("problem");
            for (int iCol = 0; iCol < dataGridView7.Columns.Count; iCol++)
            {
                dt.Columns.Add(dataGridView7.Columns[iCol].Name);
            }
            //перебор строк.
            foreach (DataGridViewRow row in dataGridView7.Rows)
            {
                DataRow datarw = dt.NewRow();
                //Подставление значений в ячейки.
                for (int iCol = 0; iCol < dataGridView7.Columns.Count; iCol++)
                {
                    datarw[iCol] = row.Cells[iCol].Value;
                }
                dt.Rows.Add(datarw);
            }
        }

        //meth - copyToDT
        private void saveChange()
        {
            try
            {
                copyToDT();

                using (SqlConnection sqlcon = new SqlConnection(p.getConnectionString()))
                {
                    //Запрос на удаление строк.
                    string sql = "DELETE FROM " + infoTableTSM.Text + " where " +
                        infoTableTSM.Text + ".[Код медицинского работника] = '0' ";
                    sqlcon.Open();
                    SqlCommand cmd = new SqlCommand(sql, sqlcon);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    //Запись измененных строк.
                    p.sqlBulk(infoTableTSM.Text,ds.Tables[0]);
                    ds.Tables.RemoveAt(0);

                    saveChanges.Enabled = false;

                    MessageBox.Show("Обновите таблицы!", "Информация",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Обновите таблицы!", "Ошибка",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //meth - excelSave
        private void overwriting()
        {
            try
            {
                //Директория сохранения.
                folderName = Properties.Settings.Default.saveDir +"\\" +
                    infoTableTSM.Text.Substring(infoTableTSM.Text.Length - 4) + "\\" +
                    infoTableTSM.Text.Substring(0, infoTableTSM.Text.Length - 4) + "\\";

                DirectoryInfo dirInf = new DirectoryInfo(folderName);
                //Проверка на наличие ошибок.
                if (dataGridView7.Rows.Count > 0)
                {
                    MessageBox.Show("После исправления ошибок" + Environment.NewLine + "необходимо обновить отчеты!", "Предупреждение!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Проверка перезаписи отчетов.
                    if (dirInf.Exists)
                    {
                        DialogResult result = MessageBox.Show("Отчеты за этот месяц уже сформированы," + Environment.NewLine +
                            "данные будут перезаписаны, продолжить ?",
                            "Перезапись", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        //Перезапись отчетов.
                        if (result == DialogResult.Yes)
                        {
                            excelSave(dataGridView2, tabPage2);
                            excelSave(dataGridView3, tabPage3);
                            excelSave(dataGridView4, tabPage4);
                            excelSave(dataGridView5, tabPage5);
                            excelSave(dataGridView6, tabPage6);

                            MessageBox.Show("Отчеты перезаписаны!", "Перезапись отчетов",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (result == DialogResult.No)
                        {

                        }
                    }
                    else
                    {
                        //Создание директории и запись отчетов.
                        Directory.CreateDirectory(folderName);

                        excelSave(dataGridView2, tabPage2);
                        excelSave(dataGridView3, tabPage3);
                        excelSave(dataGridView4, tabPage4);
                        excelSave(dataGridView5, tabPage5);
                        excelSave(dataGridView6, tabPage6);

                        MessageBox.Show("Отчеты сохранены!", "Сохрнение отчетов",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception  )
            {
                MessageBox.Show("Обновите отчеты!" , "Ошибка",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void procedure_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        // Кнопка сохранить изменения
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 5)
            {
                saveChanges.Visible = true;
                if (dataGridView7.Rows.Count < 1)
                {
                    saveChanges.Enabled = false;
                }
            }
            else saveChanges.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.saveDir == "")
            {
                MessageBox.Show("Укажите директорию сохранения отчетов!",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                button1.Enabled = false;
                overwriting();
                GC.Collect();
                button1.Enabled = true;
            }
        }
    }
}
