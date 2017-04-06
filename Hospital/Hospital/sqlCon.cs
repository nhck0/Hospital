using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;


namespace Hospital
{
    public partial class sqlCon : Form
    {
        public sqlCon()
        {
            InitializeComponent();

        }

        private static string GetConnectionString()
        {
            return "Data Source=NORD\\MSSQLSERVER1; " +
                " Integrated Security=true;" +
                "Initial Catalog=hospital;";
        }

        //sql bulk
        private void bulkCopy()
        {
            Main main = this.Owner as Main;
            if (main != null)
            {
                string connectionString = GetConnectionString();
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
                        try
                        {
                            bulkCopy.DestinationTableName = dateTimePicker1.Text;
                        
                            bulkCopy.WriteToServer(main.ds.Tables[0]);
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    
                }
            }
        }
        // Типы данных для sql 
        public DataType GetDataType(string dataType)
        {
            DataType DTTemp = null;

            switch (dataType)
            {

                case ("Номер истории болезни"):
                    DTTemp = DataType.VarChar(50);
                    break;
                case ("Код МЭС"):
                    DTTemp = DataType.Numeric(0, 18);
                    break;
                case ("Фамилия пациента"):
                    DTTemp = DataType.VarChar(50);
                    break;
                case ("Имя пациента"):
                    DTTemp = DataType.VarChar(50);
                    break;
                case ("Отчество пациента"):
                    DTTemp = DataType.VarChar(50);
                    break;
                case ("Пол пациента"):
                    DTTemp = DataType.Numeric(0, 18);
                    break;
                case ("Дата рождения пациента"):
                    DTTemp = DataType.DateTime;
                    break;
                case ("Сумма экспертная по базовому тарифу"):
                    DTTemp = DataType.Money;
                    break;
                case ("МО прикрепления"):
                    DTTemp = DataType.Numeric(0, 18);
                    break;
                case ("Код отделения"):
                    DTTemp = DataType.Numeric(0, 18);
                    break;
                case ("Код участка"):
                    DTTemp = DataType.Numeric(0, 18);
                    break;
                case ("Код подучастка"):
                    DTTemp = DataType.Numeric(0, 18);
                    break;
                case ("Диагноз"):
                    DTTemp = DataType.VarChar(50);
                    break;
                case ("Код услуги"):
                    DTTemp = DataType.VarChar(50);
                    break;
                case ("Код медицинского работника"):
                    DTTemp = DataType.Numeric(0, 18);
                    break;
                case ("Сумма экспертная по базовому тарифу итог"):
                    DTTemp = DataType.Money;
                    break;
                case ("Признак учета при контроле объемов по ТП"):
                    DTTemp = DataType.Bit;
                    break;

            }
            return DTTemp;
        }

        //Добавление таблицы в sql 
        private void addTable()
        {
            try
            {
                Main main = this.Owner as Main;
                if (main != null)
                {
                    // Establish the database server
                    string connectionString = GetConnectionString();
                    SqlConnection connection =
                       new SqlConnection(connectionString);
                    Server server =
                       new Server(new ServerConnection(connection));
                    // Create table in database
                    Database db = server.Databases["hospital"];
                    // Create new table
                    Table newTable = new Table(db, dateTimePicker1.Text);
                    Column tempC = new Column();

                    //Add the column names and types from the datatable into the new table
                    //Using the columns name and type property
                    foreach (DataColumn dc in main.ds.Tables[0].Columns)
                    {
                        //Create columns from datatable column schema
                        tempC = new Column(newTable, dc.ColumnName);
                        tempC.DataType = GetDataType(dc.ColumnName.ToString());

                        newTable.Columns.Add(tempC);
                    }

                    //  key
                    //Index index = new Index(newTable, "ID");
                    //index.IndexKeyType = IndexKeyType.DriPrimaryKey;
                    //index.IndexedColumns.Add(new IndexedColumn(index, "ID"));
                    //newTable.Indexes.Add(index);

                    newTable.Create();

                }
                bulkCopy();

                MessageBox.Show("Таблица успешно добавлена!", "Запись таблицы",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Что-то пошло не так:" +
                    Environment.NewLine + Environment.NewLine +
                    ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            addTable();
            this.Hide();
        }

        private void sqlCon_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            dateTimePicker1.CustomFormat = "MMMMyyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void sqlCon_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

    }
}