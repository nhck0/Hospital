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
        sqlDataBase db = new sqlDataBase();
        public string getConnectionString()
        {
            return "Data Source=" + Properties.Settings.Default.sqlServerName + ";" +
                " Integrated Security=true;" +
                "Initial Catalog=hospital" + Properties.Settings.Default.sqlDataBaseName + ";";
        }

        public void sqlBulk(string nameTab, System.Data.DataTable numTab)
        {

            string connectionString = getConnectionString();
            // Open a connection to the hospital database.
            using (SqlConnection connection =
                       new SqlConnection(connectionString))
            {
                connection.Open();

                // Create the SqlBulkCopy object. 
                // Note that the column positions in the source DataTable 
                // match the column positions in the destination table so 
                // there is no need to map columns. 
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
