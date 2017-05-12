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
    public partial class services : Form
    {
        public services()
        {
            InitializeComponent();
        }
        pub p = new pub();
        DataTable dt = new DataTable();

        private void delButton_Click(object sender, EventArgs e)
        {
            try {
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);
                toolStripStatusLabel1.Text = "Количество услуг: " + (dataGridView1.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(p.getConnectionString()))
            {
                string sql = "DELETE FROM [Uslugi] where  [Код услуги] is not Null ";
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                cmd.ExecuteNonQuery();
                sqlcon.Close();

                p.sqlBulk("Uslugi", dt);

                MessageBox.Show("Список услуг обновлен!", "Информация",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void services_Load(object sender, EventArgs e)
        {

            using (var sqlConn = new SqlConnection(p.getConnectionString()))
            {
                try
                {
                    var sqlCmd = new SqlCommand();
                    sqlCmd.CommandText = ("Select * From [uslugi]");
                    sqlCmd.Connection = sqlConn;
                    sqlConn.Open();
                        dt.Load(sqlCmd.ExecuteReader());
                        dataGridView1.DataSource = dt;                    
                    sqlConn.Close();
                    toolStripStatusLabel1.Text = "Количество услуг: " + (dataGridView1.Rows.Count - 1).ToString();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так :" + Environment.NewLine +
                       Environment.NewLine + ex.ToString(), "Ошибка!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Количество услуг: " + (dataGridView1.Rows.Count - 1).ToString();
        }
    }
}
