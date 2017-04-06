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

        //sqlConn
        private static string GetConnectionString()
        {
            return "Data Source=NORD\\MSSQLSERVER1; " +
                " Integrated Security=true;" +
                "Initial Catalog=hospital;";
        }
        private void excelSave(DataGridView dgv, TabPage tabp)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            

            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                ExcelWorkSheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Columns.AutoFit();
            ExcelApp.DisplayAlerts = false;
            
            ExcelWorkBook.Close(true, folderName + tabp.Text, Type.Missing);

            ExcelWorkBook = null;
            ExcelApp = null;
        }
        private void copyToDT()
        {
            
            System.Data.DataTable dt = ds.Tables.Add("problem");
            for (int iCol = 0; iCol < dataGridView7.Columns.Count; iCol++)
            {
                dt.Columns.Add(dataGridView7.Columns[iCol].Name);
            }

            foreach (DataGridViewRow row in dataGridView7.Rows)
            {

                DataRow datarw = dt.NewRow();

                for (int iCol = 0; iCol < dataGridView7.Columns.Count; iCol++)
                {
                    datarw[iCol] = row.Cells[iCol].Value;
                }

                dt.Rows.Add(datarw);
            }
        }
        //sql bulkcopy
        private void sqlBulk()
        {
            string connectionString = GetConnectionString();

            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                    try
                    {
                        bulkCopy.DestinationTableName = toolStripStatusLabel3.Text;

                        bulkCopy.WriteToServer(ds.Tables[0]);
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            ds.Tables.RemoveAt(0);
        }
        private void procedure_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
        private void overwriting()
        {
            try
            {
                folderName = "C:\\Users\\Норд\\Desktop\\Отчеты\\" +
                    toolStripStatusLabel3.Text.Substring(toolStripStatusLabel3.Text.Length - 4) + "\\" +
                    toolStripStatusLabel3.Text.Substring(0, toolStripStatusLabel3.Text.Length - 4).Substring(0, 1).ToUpper() +
                    toolStripStatusLabel3.Text.Substring(0, toolStripStatusLabel3.Text.Length - 4).Remove(0, 1) + "\\";

                DirectoryInfo dirInf = new DirectoryInfo(folderName);


                if (dirInf.Exists)
                {
                    DialogResult result = MessageBox.Show("Отчеты за этот месяц уже сформированы,"+ Environment.NewLine+
                        "данные будут перезаписаны, продолжить ?",
                        "Перезапись", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


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
                    Directory.CreateDirectory(folderName);

                    if (dataGridView7.Rows.Count > 0)
                    {
                        MessageBox.Show("После исправления ошибок необходимо обновить таблицы!", "Предупреждение!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
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
            catch (Exception)
            {
                MessageBox.Show("Обновите таблицы!", "Ошибка",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //procDialog
        private void button1_Click(object sender, EventArgs e)
        {
            procedureDialog procd = new procedureDialog();
            procd.Owner = this;
            procd.ShowDialog();
        }

        private void procedure_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            this.AcceptButton = button1;
        }
        //saveExcel
        private void button3_Click(object sender, EventArgs e)
        {
            overwriting();

            GC.Collect();
        }
        //copyDT and sqlbulk
        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i< dataGridView7.Rows.Count; i++)
                {
                    if (dataGridView7.Rows[i].Cells[14].Value.ToString() == "0")
                    {
                        sum++;
                    }
                }

            if (sum > 0)
            {
                MessageBox.Show("В таблице остались оишбки!" + Environment.NewLine + "Количество ошибок: " + sum, "Предупреждение!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                copyToDT();

                using (SqlConnection sqlcon = new SqlConnection(GetConnectionString()))
                {
                string sql = "DELETE FROM " + toolStripStatusLabel3.Text + " where " + toolStripStatusLabel3.Text + ".[Код медицинского работника] = '0' ";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                sqlBulk();

                button2.Enabled = false;

                MessageBox.Show("Обновите таблицы!", "Информация",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 5)
            {
                button2.Visible = true;
            }
            else button2.Visible = false;
        }

        private void главноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьОтчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excelSave(dataGridView2, tabPage2);
            excelSave(dataGridView3, tabPage3);
            excelSave(dataGridView4, tabPage4);
            excelSave(dataGridView5, tabPage5);
            excelSave(dataGridView6, tabPage6);
            GC.Collect();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
