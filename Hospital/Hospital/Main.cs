﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelObj = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace Hospital
{
   
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            
        }

        OpenFileDialog ofd = new OpenFileDialog();
        DataTable dt = new DataTable();
       // DataTable tb2 = new DataTable();
        public DataSet ds = new DataSet();
        pub p = new pub();
        
        private void Main_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.sqlDataBaseName == "")
            {
                infoDBTSM.Text = "Подключено к базе данных: Нет подключениея";
            }
            else infoDBTSM.Text = "Подключено к базе данных: " + Properties.Settings.Default.sqlDataBaseName;

            addToDataBase.Enabled = false;
        }

        //block button 
        private void openReestr_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sqlDataBaseName == "")
            {
                MessageBox.Show("Проверьте подключение к базе данных!",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //Выборка необходимых столбцов
                openFile("[Номер истории болезни],[Код МЭС],[Фамилия пациента],[Имя пациента],[Отчество пациента],"+
                    "[Пол пациента],[Дата рождения пациента],[Сумма экспертная по базовому тарифу],[МО прикрепления],"+
                    "[Код отделения, в котором оказана услуга] as [Код отделения],[Код участка, в котором оказана услуга] as [Код участка],"+
                    "[Код подучастка, в котором оказана услуга] as [Код подучастка],[Диагноз],[Код услуги],"+
                    "[Код медицинского работника, оказавшего медицинскую услугу] as [Код медицинского работника],"+
                    "[Сумма экспертная по базовому тарифу итог],[Признак учета при контроле объемов по ТП]");
                infoRowTSM.Text = "Количество записей: " + dataGridView1.Rows.Count.ToString();
            }
        }

        private void addToDataBase_Click(object sender, EventArgs e)
        {
            sqlCon f = new sqlCon();
            f.Owner = this;
            f.ShowDialog();
        }

        private void addStaff_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sqlDataBaseName == "")
            {
                MessageBox.Show("Проверьте подключение к базе данных!",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
            {
                try
                {
                    //Выборка необходимых столбцов
                    openFile("[Код],[ФИО мед Работника],[Отделение],[Участок],[Пункт],[Наименование],"+
                        "[Специальность],[Кол-во ставок],[Дата начала],[Дата окончания],[Табельный номер],"+
                        "[Тип занятия должности],[МО по основному месту работы],"+
                        "[Вид должности],[Реквизитты документа о принятии на работу]");

                    infoRowTSM.Text = "Количество записей: " + dataGridView1.Rows.Count.ToString();
                    
                    // Заперт выгрузки пустых файлов.
                    if (dataGridView1.Rows.Count != 0 && dataGridView1.Columns[0].Name == "Код")
                    {
                        using (SqlConnection sqlcon = new SqlConnection(p.getConnectionString()))
                        {
                            //Удаление всех записей
                            string sql = "DELETE FROM [RepStaf196] where  [Код] is not Null ";
                            sqlcon.Open();
                            SqlCommand cmd = new SqlCommand(sql, sqlcon);
                            cmd.ExecuteNonQuery();
                            sqlcon.Close();
                            
                            //Заполнение таблицы RepStaf196 новым набором записей
                            p.sqlBulk("RepStaf196", ds.Tables[0]);

                            MessageBox.Show("Штат обновлен!", "Информация",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("В используемой базе данных" + Environment.NewLine +
                        "нет таблицы штат!" + Environment.NewLine + Environment.NewLine + "Таблица не будет обновлена!",
                        "Ошибка обновления!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void reports_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sqlDataBaseName == "")
            {
                MessageBox.Show("Проверьте подключение к базе данных!",
                     "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            procedure proc = new procedure();
            proc.ShowDialog();
            }
        }

        //block TSM 
        private void reestrTSM_Click(object sender, EventArgs e)
        {
            openReestr_Click(sender, e);
        }

        private void staffTSM_Click(object sender, EventArgs e)
        {
            addStaff_Click(sender,e);            
        }

        private void reportsTSM_Click(object sender, EventArgs e)
        {
            reports_Click(sender, e);
        }

        private void aboutTheProgramTSM_Click(object sender, EventArgs e)
        {
            aboutTheProgram atp = new aboutTheProgram();
            atp.ShowDialog();
        }

        private void exitTSM_Click(object sender, EventArgs e)
        {
            Main_FormClosed(sender, (e as FormClosedEventArgs));
        }

        private void connToTheDBTSM_Click(object sender, EventArgs e)
        {
            sqlDataBase db = new sqlDataBase();
            db.Owner = this;
            db.ShowDialog();
        }

        private void saveDirTSM_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            Properties.Settings.Default.saveDir = folderBrowserDialog1.SelectedPath;
        }

        // block methods 
        private void openFile(string columnsName)
        {
            try
            {
                ofd.DefaultExt = "*.xls;*.xlsx";
                ofd.Filter = "All files(*.*)|*.*|Excel 2007(*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
                ofd.Title = "Выберите документ для загрузки данных";
               
                importTB(columnsName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так:" + Environment.NewLine +
                    Environment.NewLine + ex.Message);
            }
        }

        private void importTB(string columnsName)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                ds.Clear();
                dt.Rows.Clear();
                dt.Columns.Clear();
                //backgroundWorker1.RunWorkerAsync();
                try
                {
                   
                    infoFolderTSM.Text = "Директория файла: " + ofd.FileName;
                    infoFolderTSM.Visible = true;
                    infoDBTSM.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    //Строка подключения
                    String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                                ofd.FileName +
                                ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                    System.Data.OleDb.OleDbConnection con =
                        new System.Data.OleDb.OleDbConnection(constr);
                    con.Open();

                    //Разметка таблицы
                    DataTable schemaTable = con.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });

                    //Номер листа
                    

                    string sheet1 = (string)schemaTable.Rows[0].ItemArray[2];
                    //Запрос на выборку
                    string select = String.Format("SELECT " + columnsName + " FROM[{0}]", sheet1); 

                    tabControl1.TabPages[0].Text = sheet1.ToString();
                    //Вызов запроса
                    System.Data.OleDb.OleDbDataAdapter ad =
                        new System.Data.OleDb.OleDbDataAdapter(select, con);
                    //Заполнение DataSet данными              
                    ad.Fill(ds);
                    //Заполнение dataTable из dataSet
                    dt = ds.Tables[0];
                    con.Close();
                    //Заполнение DGV из dataTable
                    dataGridView1.DataSource = dt;
                    addToDataBase.Enabled = true;
                    con.Close();


                    // УДАЛИТЬ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    if (dataGridView1.Columns[0].Name == "Номер истории болезни")
                    {
                        dataGridView1.Columns[14].Visible = false;
                    }
                    if (dataGridView1.Columns[0].Name == "Код")
                    {
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].Visible = false;
                        dataGridView1.Columns[10].Visible = false;
                        dataGridView1.Columns[14].Visible = false;
                    }
                    // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

                    // Для скливания листов
                    //if (schemaTable.Rows.Count == 2)
                    //{
                    //    button2.Enabled = true;
                    //    ds.Tables.Add("tb2");

                    //    string sheet2 = (string)schemaTable.Rows[0].ItemArray[2]; //numSheet
                    //    string select2 = String.Format("SELECT [Номер истории болезни],[Код МЭС],[Фамилия пациента],[Имя пациента],[Отчество пациента],[Пол пациента],[Дата рождения пациента],[Сумма экспертная по базовому тарифу],[МО прикрепления],[Код отделения, в котором оказана услуга] as [Код отделения],[Код участка, в котором оказана услуга] as [Код участка],[Код подучастка, в котором оказана услуга] as [Код подучастка],[Диагноз],[Код услуги],[Код медицинского работника, оказавшего медицинскую услугу] as [Код медицинского работника],[Сумма экспертная по базовому тарифу итог],[Признак учета при контроле объемов по ТП] FROM[{0}]", sheet2);

                    //    System.Data.OleDb.OleDbDataAdapter ad2 =
                    //   new System.Data.OleDb.OleDbDataAdapter(select, con);

                    //    ad2.Fill(ds);
                    //    tb2 = ds.Tables[1];
                    //    con.Close();
                    //    dataGridView1.DataSource = tb2;
                    //}
                }
                catch (Exception ex)
                {
                    addToDataBase.Enabled = false;
                    MessageBox.Show("Содержимое файла не соответствует требуемому формату" + ex.Message, "Ошибка!" ,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        // visible - false
        private void gluingSheets_Click(object sender, EventArgs e)
        {
            //foreach (DataRow row in tb2.Rows)
            //{
               // tb.ImportRow(row);
            //}
            //for (int i = 0; i < dataGridView2.Columns.Count; i++)
            //{
            //    for (int j = 0; j < dataGridView1.Columns.Count; j++)
            //        if (dataGridView2.Columns[i].Name == dataGridView1.Columns[j].Name)
            //        {
            //            for (int numr = 0; numr < dataGridView2.Rows.Count - 1; numr++)
            //            {
            //                        dt.Rows.Add(dt.NewRow());
            //                        dt.AcceptChanges();

            //                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[j].Value
            //                        = dataGridView2.Rows[numr].Cells[i].Value;
            //            }

            //        }
            //}
        }

        private void Services_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sqlDataBaseName == "")
            {
                MessageBox.Show("Проверьте подключение к базе данных!", "Предупреждение!",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                services serv = new services();
                serv.ShowDialog();
            }
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i == 0 ; i++)
            {
                ((BackgroundWorker)sender).ReportProgress(i);
               
            }
            //progressBar1.MarqueeAnimationSpeed = 30;
        }
    }
}



//private void numSheets()
//{
//    ExcelObj.Application app = new ExcelObj.Application();
//    dt.Rows.Clear();
//    dt.Columns.Clear();
//    dt1.Rows.Clear();
//    dt1.Columns.Clear();
//    if (ofd.ShowDialog() == DialogResult.OK)
//    {

//        toolStripStatusLabel1.Text = ofd.FileName;
//        workbook = app.Workbooks.Open(ofd.FileName);

//        //Устанавливаем номер листа из котрого будут извлекаться данные
//        //Листы нумеруются от 1
//        NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
//        ShtRange = NwSheet.UsedRange;
//        for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
//        {

//            dt.Columns.Add(
//           new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
//        }
//        dt.AcceptChanges();

//        string[] columnNames = new String[dt.Columns.Count];
//        for (int i = 0; i < dt.Columns.Count; i++)
//        {
//            columnNames[0] = dt.Columns[i].ColumnName;
//        }

//        for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
//        {
//            DataRow dr = dt.NewRow();
//            for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
//            {
//                if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
//                {
//                    dr[Cnum - 1] =
//                    (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
//                }
//            }
//            dt.Rows.Add(dr);
//            dt.AcceptChanges();
//        }
//        tabControl1.TabPages[0].Text = NwSheet.Name;
//        dataGridView1.DataSource = dt;

//        if (workbook.Worksheets.Count == 2)
//        {

//            NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(2);
//            ShtRange = NwSheet.UsedRange;
//            for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
//            {
//                dt1.Columns.Add(
//               new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
//            }
//            dt1.AcceptChanges();

//            string[] columnNames1 = new String[dt1.Columns.Count];
//            for (int i = 0; i < dt1.Columns.Count; i++)
//            {
//                columnNames1[0] = dt1.Columns[i].ColumnName;
//            }

//            for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
//            {
//                DataRow dr1 = dt1.NewRow();
//                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
//                {
//                    if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
//                    {
//                        dr1[Cnum - 1] =
//                        (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
//                    }
//                }
//                dt1.Rows.Add(dr1);
//                dt1.AcceptChanges();
//            }
//            tabControl1.TabPages[1].Text = NwSheet.Name;
//            dataGridView2.DataSource = dt1;
//        }

//        else
//        {
//            dataGridView2.Columns.Clear();
//            app.Quit();

//        }
//        app.Quit();
//    }
//    else
//    {
//        MessageBox.Show("Вы не выбрали файл",
//    "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }

//}


//private void openFile()
//{
//    DataSet ds = new DataSet();
//    ofd.DefaultExt = "*.xls;*.xlsx";
//    ofd.Filter = "Excel 2007(*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls";
//    ofd.Title = "Выберите документ для загрузки данных";

//    if (ofd.ShowDialog() == DialogResult.OK)
//    {
//        label1.Text = ofd.FileName;

//        String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
//                        ofd.FileName +
//                        ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

//        System.Data.OleDb.OleDbConnection con =
//            new System.Data.OleDb.OleDbConnection(constr);
//        con.Open();

//        DataTable schemaTable = con.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables,
//            new object[] { null, null, null, "TABLE" });
//        //try
//        //{
//        //    if ((string)schemaTable.Rows[1].ItemArray[2] != null)
//        //    {

//        //    }
//        //}
//        //catch (IndexOutOfRangeException)
//        //{

//        //}
//        string sheet1 = (string)schemaTable.Rows[0].ItemArray[2];
//        string sheet2 = (string)schemaTable.Rows[1].ItemArray[2];
//        string select = String.Format("SELECT * FROM [{0}]", sheet1);
//        string select2 = String.Format("SELECT * FROM [{0}]", sheet2);
//        //tabControl1.TabPages[0].Text = sheet1.ToString();
//        System.Data.OleDb.OleDbDataAdapter ad =
//        new System.Data.OleDb.OleDbDataAdapter(select, con);

//        ad.Fill(ds);

//        DataTable tb = ds.Tables[0];
//        con.Close();
//        dataGridView1.DataSource = tb;
//        if (sheet2 != null)
//        {
//            ds.Clear();
//            System.Data.OleDb.OleDbDataAdapter ad2 =
//        new System.Data.OleDb.OleDbDataAdapter(select2, con);
//            ad2.Fill(ds);

//            DataTable tb2 = ds.Tables[0];
//            con.Close();
//            dataGridView2.DataSource = tb2;
//        }
//        con.Close();

//    }
//    else
//    {
//        MessageBox.Show("Вы не выбрали файл для открытия",
//                "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}