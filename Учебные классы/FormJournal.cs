using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class FormJournal : Form {
        public FormJournal() {
            InitializeComponent(); 
            DoubleBuffered = true;
        }

        private string nameClassJournal = "",
                       nameSeatJournal = "";

        private void FormAssistant_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Form_Load(object sender, EventArgs e) {

            Timer timer = new Timer();
            timer.Interval = (10 * 1000); // 10 secs
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
            TimerTick(this, new EventArgs());

            cbxClassesJournal.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxClassesJournal.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxSeatsJournal.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxSeatsJournal.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public void TimerTick(object sender, EventArgs e) {
            //refresh here...
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;

            cmd.CommandText = "select distinct\"Класс\" from журнал_обслуживания WHERE \"Дата установки\" is not null";

            cbxClassesJournal.Items.Clear();

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {

                    lblClassTabJournal.Text = reader.GetName(0);

                    while (reader.Read())
                        cbxClassesJournal.Items.Add(reader.GetString(0));
                }
            }


            if (cbxClassesJournal.SelectedItem != null && cbxSeatsJournal.SelectedItem != null) {

                dataJournal.DataSource = GetData("select \"Дата установки\",\"Дата снятия\", " +
                    "\"Инв. №\",\"Тип\",\"Характеристика\",\"Исправность оборуд.\" from журнал_обслуживания " +
                    "where \"Класс\"='" + nameClassJournal + "' and \"№ места\"='" + nameSeatJournal + "'");
            }
        }

        private DataTable GetData(string query) {

            DataTable dataTable = new DataTable();

            OracleCommand cmd = new OracleCommand(query);

            cmd.CommandType = CommandType.Text;
            cmd.Connection = Program.con;

            OracleDataReader reader = cmd.ExecuteReader();
            DataTable dtSchema = reader.GetSchemaTable();
            List<DataColumn> listCols = new List<DataColumn>();

            if (dtSchema != null) {
                foreach (DataRow drow in dtSchema.Rows) {
                    string columnName = Convert.ToString(drow["ColumnName"]);
                    DataColumn column = new DataColumn(columnName, (Type)drow["DataType"]);
                    listCols.Add(column);
                    dataTable.Columns.Add(column);
                }
            }

            listCols[5].DataType = typeof(bool);

            // Read rows from DataReader and populate the DataTable 
            while (reader.Read()) {
                DataRow dataRow = dataTable.NewRow();

                for (int i = 0; i < listCols.Count; i++) {
                    dataRow[listCols[i]] = i == 5 ?
                        reader[i].ToString().Equals("1") ?
                            "true" : "false"
                                      : reader[i];
                }

                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }



        private void cbxClassesJournal_SelectedIndexChanged(object sender, EventArgs e) {

            nameClassJournal = cbxClassesJournal.SelectedItem.ToString();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select distinct \"№ места\" from журнал_обслуживания where \"Класс\"='" + nameClassJournal + "'";

            dataJournal.DataSource = null;
            txtBoxNoteJournal.Text = null;

            cbxSeatsJournal.Text = "";
            cbxSeatsJournal.Items.Clear();

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxSeatsJournal.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void cbxSeatsJournal_SelectedIndexChanged(object sender, EventArgs e) {

            nameSeatJournal = cbxSeatsJournal.SelectedItem.ToString();

            dataJournal.DataSource = GetData("select \"Дата установки\",\"Дата снятия\", " +
                            "\"Инв. №\",\"Тип\",\"Характеристика\",\"Исправность оборуд.\" from журнал_обслуживания " +
                            "where \"Класс\"='" + nameClassJournal + "' and \"№ места\"='" + nameSeatJournal + "' and \"Инв. №\" is not null");

            dataJournal.Focus();
            dataJournal_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        }


        private void dataJournal_CellClick(object sender, DataGridViewCellEventArgs e) {
            
            txtBoxNoteJournal.Text = null;

            if (dataJournal.SelectedRows.Count != 0) {

                string numberEquip = dataJournal.SelectedRows[0].Cells[2].Value.ToString();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.con;

                string query = "select distinct \"Примечание оборуд.\" from журнал_обслуживания " +
                            "where \"Инв. №\"='" + numberEquip + "'";
                cmd.CommandText = query;
                string note =  cmd.ExecuteScalar().ToString();

                txtBoxNoteJournal.Text = note;
            }
        }
    }
}
