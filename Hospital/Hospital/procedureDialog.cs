﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hospital
{
    public partial class procedureDialog : Form
    {
        public procedureDialog()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        int tab = 0;
        pub p = new pub();

        //proc form sql
        private void procWithOutParam(string nameProcedure)
        {
            procedure proc = this.Owner as procedure;
            using (var sqlConn = new SqlConnection(p.getConnectionString()))
            {
                try
                {
                    //Вызов процедуры из БД без параметра
                    var sqlCmd = new SqlCommand(nameProcedure, sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlConn.Open();
                    using (SqlDataReader dr = sqlCmd.ExecuteReader())
                    {
                        //Заполнение таблицы данными.
                        ds.Tables[tab].Load(dr);
                        tab++;
                    }
                    sqlConn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так :" + Environment.NewLine +
                       Environment.NewLine + ex.ToString(), "Ошибка!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void procWithParam(string nameProcedure, string paramValue )
        {
            procedure proc = this.Owner as procedure;
            using (var sqlConn = new SqlConnection(p.getConnectionString()))
            { 
                try
                {
                    //Вызов процедуры из БД с параметром
                    var sqlCmd = new SqlCommand(nameProcedure, sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@nameTab", paramValue);

                    sqlConn.Open();
                    using (SqlDataReader dr = sqlCmd.ExecuteReader())
                    {
                        //Заполнение таблицы данными.
                        ds.Tables[tab].Load(dr);
                        tab++;
                    }
                    sqlConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так :" + Environment.NewLine +
                       Environment.NewLine + ex.ToString(), "Ошибка!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Fill dataGridView
        private void fillDGV()
        {
            procedure proc = this.Owner as procedure;
            try
            { 
                var nameProcWOP = new string[] { "Посещения по врачам", "Нормативы мед помощи", "Посещения по отделениям" };
                var nameProcWP = new string[] { "Услуги амбулаторной хирургии", "Диспансеризация", "Найти ошибки" };

                //Обновление всех таблиц.
                using (var sqlConn = new SqlConnection(p.getConnectionString()))
                    {
                        var sqlCmd = new SqlCommand("Собрать все", sqlConn);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@nameTab", dateTimePicker1.Text);

                        sqlConn.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlConn.Close();
                    }
                //Формирование отчетов и заполнение DGV.
                foreach (var collProc in nameProcWP)
                {
                    procWithParam(collProc, dateTimePicker1.Text);
                }

                foreach (var collProc in nameProcWOP)
                {
                    procWithOutParam(collProc);
                }

                proc.infoTableTSM.Text = dateTimePicker1.Text;
                proc.dataGridView4.DataSource = ds.Tables[0];
                proc.dataGridView6.DataSource = ds.Tables[1];
                proc.dataGridView7.DataSource = ds.Tables[2];
                proc.dataGridView2.DataSource = ds.Tables[3];
                proc.dataGridView3.DataSource = ds.Tables[4];
                proc.dataGridView5.DataSource = ds.Tables[5];
                this.Hide();




                // УДАЛИТЬ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                for (int i = 0; i < proc.dataGridView3.Rows.Count; i++)
                {
                    proc.dataGridView3.Rows[i].Cells[2].Value = i + 1;
                    proc.dataGridView3.Rows[i].Cells[1].Value = i + 1;
                    proc.dataGridView3.Rows[i].Cells[3].Value = "Иванов Иван Иванович";
                }
                for (int i = 0; i < proc.dataGridView4.Rows.Count; i++)
                {
                    proc.dataGridView4.Rows[i].Cells[1].Value = i + 1;
                    proc.dataGridView4.Rows[i].Cells[2].Value = "Иванов Иван Иванович";
                }
                for (int i = 0; i < proc.dataGridView6.Rows.Count; i++)
                {
                    proc.dataGridView6.Rows[i].Cells[1].Value = i + 1;
                    proc.dataGridView6.Rows[i].Cells[0].Value = "Иванов Иван Иванович";
                } 
                proc.dataGridView2.Columns[1].Visible = false;
                proc.dataGridView2.Columns[2].Visible = false;
                proc.dataGridView5.Columns[2].Visible = false;
                proc.dataGridView5.Columns[4].Visible = false;
                // УДАЛИТЬ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            }
            catch(Exception)
            {
                proc.infoTableTSM.Text = "";
                MessageBox.Show("Такой таблицы не существует!", "Ошибка!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
        }
        private void procedureDialog_Load(object sender, EventArgs e)
        {
            procedure proc = this.Owner as procedure;
            this.AcceptButton = acceptButton;
            dateTimePicker1.CustomFormat = "MMMMyyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Text = proc.infoTableTSM.Text;
            DataTable posvr = ds.Tables.Add("Посещения по врачам");
            DataTable standarts = ds.Tables.Add("Нормативы мед помощи");
            DataTable uslug = ds.Tables.Add("Услуги амублаторной хирургии");
            DataTable visits = ds.Tables.Add("Посещения по отделениям");
            DataTable disp = ds.Tables.Add("Диспансеризация");
            DataTable problem = ds.Tables.Add("Найти ошибки");
        }

        //sql procedure
        private void acceptButton_Click(object sender, EventArgs e)
        {
            procedure proc = this.Owner as procedure;
            try
            {   
                fillDGV();

                proc.infoTSM.Text = "Данные на основе таблицы: ";

                if (proc.dataGridView7.Rows.Count == 0)
                {
                    proc.infoErrorTSM.Image = Properties.Resources.noError;
                    proc.infoErrorTSM.Text = "Ошибок не найдено!";
                    proc.saveChanges.Enabled = false;
                }
                else
                {
                    proc.infoErrorTSM.Image = Properties.Resources.Error;
                    proc.infoErrorTSM.Text = "Найдены ошибки!";
                    proc.tabControl1.SelectedIndex = 5;
                    proc.saveChanges.Enabled = true;
                    MessageBox.Show("Найдены ошибки!", "Ошибки!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так: " + Environment.NewLine +
                   Environment.NewLine + ex.ToString(), "Ошибка!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
