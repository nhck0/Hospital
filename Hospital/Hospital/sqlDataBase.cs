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
    public partial class sqlDataBase : Form
    {
        public sqlDataBase()
        {
            InitializeComponent();
        }

        private void checkConn()
        {
            main main = this.Owner as main;
            try
            {
                using (SqlConnection sqlConn =
                    new SqlConnection("Server=" + nameServerBT.Text + ";Persist Security Info=false;" +
                "Initial Catalog=" + nameDataBaseBT.Text + ";User ID=" + loginBT.Text +";Password=" + passBT.Text))
                {
                    //Проверка подключения к базе данных
                    sqlConn.Open();
                    MessageBox.Show("Подключение установлено!", "Подключение...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.sqlServerName = nameServerBT.Text;
                    Properties.Settings.Default.sqlDataBaseName = nameDataBaseBT.Text;
                    Properties.Settings.Default.sqlLogin = loginBT.Text;
                    Properties.Settings.Default.sqlPassword = passBT.Text;
                    main.infoDBTSM.Text = "Подключено к базе данных: " + Properties.Settings.Default.sqlDataBaseName;
                    this.Hide();
                }
                
            }
            catch (SqlException ex )
            {
                MessageBox.Show("Нет соединения с базой!" + ex, "Подключение...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет соединения с базой!" + ex, "Подключение...",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkConnection_Click(object sender, EventArgs e)
        {
            checkConn();
        }

        private void sqlDataBase_Load(object sender, EventArgs e)
        {
            AcceptButton = checkConnection;
            nameServerBT.Text = Properties.Settings.Default.sqlServerName;
            nameDataBaseBT.Text = Properties.Settings.Default.sqlDataBaseName;
        }
    }
}
