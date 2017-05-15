using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital
{
    class pub
    {
        public string getConnectionString()
        {
            // return "Server=" + Properties.Settings.Default.sqlServerName + ";Persist Security Info=false;" +
            //   "Initial Catalog=" + Properties.Settings.Default.sqlDataBaseName + "User ID =" + Properties.Settings.Default.sqlLogin +";Password=" + Properties.Settings.Default.sqlPassword +";"; 
            return "Server=" + Properties.Settings.Default.sqlServerName + ";Persist Security Info=false;" +
               "Initial Catalog=" + Properties.Settings.Default.sqlDataBaseName + ";User ID=" + Properties.Settings.Default.sqlLogin + ";Password=" + Properties.Settings.Default.sqlPassword;
        }

        public void sqlBulk(string nameTab, System.Data.DataTable numTab)
        {
            string connectionString = getConnectionString();
            // Open a connection to database.
            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                connection.Open();
 
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                {
                        bulkCopy.DestinationTableName = nameTab;

                        bulkCopy.WriteToServer(numTab);
                        connection.Close();
                }
            }
        }

    }
}
