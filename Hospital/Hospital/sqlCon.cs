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
        pub p = new pub();

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
            Main main = this.Owner as Main;
            try
            { 
                if (main != null)
                {
                    // Establish the database server
                    string connectionString = p.getConnectionString();
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
                p.sqlBulk(dateTimePicker1.Text,main.ds.Tables[0]);

                MessageBox.Show("Таблица успешно добавлена!", "Запись таблицы",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                if (main.dataGridView1.Columns[0].Name == "Номер истории болезни")
                {
                    MessageBox.Show("Таблица с таким именем уже существует!", 
                        "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (main.dataGridView1.Columns[0].Name == "Код")
                {
                    MessageBox.Show("Добавлять штат в базу данных не нужно!", 
                        "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так:" +
                    Environment.NewLine + Environment.NewLine +
                    ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void addToDB_Click(object sender, EventArgs e)
        {
            addTable();
        }

        private void sqlCon_Load(object sender, EventArgs e)
        {
            this.AcceptButton = addToDB;
            dateTimePicker1.CustomFormat = "MMMMyyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void sqlCon_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

    }
}