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
                    var sqlCmd = new SqlCommand(nameProcedure, sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlConn.Open();
                    using (SqlDataReader dr = sqlCmd.ExecuteReader())
                    {
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
                    var sqlCmd = new SqlCommand(nameProcedure, sqlConn);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@nameTab", paramValue);

                    sqlConn.Open();
                    using (SqlDataReader dr = sqlCmd.ExecuteReader())
                    {
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
                var nameProcWOP = new string[] { "num001", "num002", "num004" };
                var nameProcWP = new string[] { "num003", "num005", "Найти ошибки" };

                using (var sqlConn = new SqlConnection(p.getConnectionString()))
                    {
                        var sqlCmd = new SqlCommand("assembleAll", sqlConn);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@nameTab", dateTimePicker1.Text);

                        sqlConn.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlConn.Close();
                    }

            foreach (var collProc in nameProcWP)
            {
                procWithParam(collProc, dateTimePicker1.Text);
            }

            foreach (var collProc in nameProcWOP)
            {
                procWithOutParam(collProc);
            }
                proc.toolStripStatusLabel3.Text = dateTimePicker1.Text;
                proc.dataGridView4.DataSource = ds.Tables[0];
                proc.dataGridView6.DataSource = ds.Tables[1];
                proc.dataGridView7.DataSource = ds.Tables[2];
                proc.dataGridView2.DataSource = ds.Tables[3];
                proc.dataGridView3.DataSource = ds.Tables[4];
                proc.dataGridView5.DataSource = ds.Tables[5];
                this.Hide();
            }
            catch(Exception)
            {
                proc.toolStripStatusLabel3.Text = "";
                MessageBox.Show("Такой таблицы не существует!", "Ошибка!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
        }
        private void procedureDialog_Load(object sender, EventArgs e)
        {
            procedure proc = this.Owner as procedure;
            this.AcceptButton = button1;
            dateTimePicker1.CustomFormat = "MMMMyyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Text = proc.toolStripStatusLabel3.Text;
            DataTable posvr = ds.Tables.Add("Посещения по врачам");
            DataTable standarts = ds.Tables.Add("Нормативы мед помощи");
            DataTable uslug = ds.Tables.Add("Услуги амублаторной хирургии");
            DataTable visits = ds.Tables.Add("Посещения по отделениям");
            DataTable disp = ds.Tables.Add("Диспансеризация");
            DataTable problem = ds.Tables.Add("Найти ошибки");
        }

        //sql procedure
        private void button1_Click(object sender, EventArgs e)
        {
            procedure proc = this.Owner as procedure;
            try
            {   
                fillDGV();

                proc.toolStripStatusLabel2.Text = "Данные на основе таблицы: ";

                if (proc.dataGridView7.Rows.Count == 0)
                {
                    proc.toolStripStatusLabel1.Text = "Ошибок не найдено!";
                    proc.button2.Enabled = false;
                }
                else
                {
                    proc.toolStripStatusLabel1.Text = "Найдены ошибки!";
                    proc.tabControl1.SelectedIndex = 5;
                    proc.button2.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
