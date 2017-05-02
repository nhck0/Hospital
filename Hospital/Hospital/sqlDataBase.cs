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

        private void sqlDataBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.sqlServerName = textBox1.Text;
            Properties.Settings.Default.sqlDataBaseName = textBox2.Text;
        }

        private void checkConn()
        {
            pub b = new pub();
            try
            {
                b.getConnectionString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkConn();
        }
    }
}
