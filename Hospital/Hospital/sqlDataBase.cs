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

        private bool checkConn()
        {
            Main main = this.Owner as Main;
            try
            {
                using (SqlConnection sqlConn =
                    new SqlConnection("Data Source=" + nameServerTB.Text + ";" +
                " Integrated Security=true;" +
                "Initial Catalog=" + nameDataBaseTB.Text + ";"))
                {
                    sqlConn.Open();
                    MessageBox.Show("Подключение установлено!", "Подключение...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.sqlServerName = nameServerTB.Text;
                    Properties.Settings.Default.sqlDataBaseName = nameDataBaseTB.Text;
                    main.infoDBTSM.Text = "Подключено к базе данных: " + Properties.Settings.Default.sqlDataBaseName;
                    return (sqlConn.State == ConnectionState.Open);                
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Нет соединения с базой!", "Подключение...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            catch (Exception)
            {
                MessageBox.Show("Нет соединения с базой!", "Подключение...",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void checkConnection_Click(object sender, EventArgs e)
        {
            checkConn();
        }

        private void sqlDataBase_Load(object sender, EventArgs e)
        {
            AcceptButton = checkConnection;
            nameServerTB.Text = Properties.Settings.Default.sqlServerName;
            nameDataBaseTB.Text = Properties.Settings.Default.sqlDataBaseName;
        }
    }
}
