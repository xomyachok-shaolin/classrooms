using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class FormAssistant : Form {
        public FormAssistant() {
            InitializeComponent(); 
            DoubleBuffered = true;
        }

        private const string textNameWorkstation = "Имя рабочей станции: ",
                             textIP = "IP-адрес: ";

        private string nameClass,
                       nameSeat,
                       nameWorkstation;

        private void FormAssistant_FormClosed(object sender, FormClosedEventArgs e) {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Timer timer = new Timer();
            timer.Interval = (30 * 1000); // 30 secs
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
            TimerTick(this, new EventArgs());


            cbxClasses.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxClasses.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxSeats.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxSeats.AutoCompleteSource = AutoCompleteSource.ListItems;

            lblNameWorkstation.Text = textNameWorkstation;
            lbl_IP.Text = textIP;

            btnSetEquip.Enabled = false;
            btnTakeOffEquip.Enabled = false;
            btnTransferEquip.Enabled = false;
        }

        public void TimerTick(object sender, EventArgs e) {
            //refresh here...
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;


            cmd.CommandText = "select distinct\"Класс\" from оборуд_учебного_места WHERE ид_класса is not null";

            cbxClasses.Items.Clear();

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {

                    lblClass.Text = reader.GetName(0);

                    while (reader.Read())
                        cbxClasses.Items.Add(reader.GetString(0));
                }
            }

            if (cbxClasses.SelectedItem != null && cbxSeats.SelectedItem != null) {

                dataEquip.DataSource = GetData("select \"Инв. №\",\"Тип\",\"Характеристика\",\"Исправность оборуд.\" " +
                "from оборуд_учебного_места " +
                "where \"Класс\"='" + nameClass + "' and \"№ места\"='" + nameSeat + "' and \"Инв. №\" is not null");
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

            listCols[3].DataType = typeof(bool);

            // Read rows from DataReader and populate the DataTable 
            while (reader.Read()) {
                DataRow dataRow = dataTable.NewRow();

                for (int i = 0; i < listCols.Count; i++) {
                    dataRow[listCols[i]] = i == 3 ?
                        reader[i].ToString().Equals("1") ?
                            "true" : "false"
                        : reader[i];
                }

                dataTable.Rows.Add(dataRow);
            }
            
            return dataTable;
        }

        private void cbxClasses_SelectedIndexChanged(object sender, EventArgs e) {

            nameClass = cbxClasses.SelectedItem.ToString();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select distinct \"№ места\" from оборуд_учебного_места " +
                "where \"Класс\"='" + nameClass + "' and \"№ места\" is not null";

            dataEquip.DataSource = null;
            txtBoxNote.Text = null;
            lblNameWorkstation.Text = textNameWorkstation;
            lbl_IP.Text = textIP;

            btnSetEquip.Enabled = false;
            btnTakeOffEquip.Enabled = false;
            btnTransferEquip.Enabled = false;

            cbxSeats.Text = "";
            cbxSeats.Items.Clear();

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxSeats.Items.Add(reader.GetString(0));
                    }
                }
            }
        }
        private void cbxSeats_SelectedIndexChanged(object sender, EventArgs e) {

            nameSeat = cbxSeats.SelectedItem.ToString();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select distinct \"Имя рабочей станции\", \"IP-адрес\" from оборуд_учебного_места " +
                "where \"Класс\"='" + nameClass + "' and \"№ места\"='" + nameSeat + "'";

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        nameWorkstation = reader.GetString(0);
                        lblNameWorkstation.Text = textNameWorkstation + nameWorkstation;
                        lbl_IP.Text = textIP + reader.GetString(1);
                    }
                }
            }

            dataEquip.DataSource = GetData("select \"Инв. №\",\"Тип\",\"Характеристика\",\"Исправность оборуд.\" " +
                "from оборуд_учебного_места " +
                "where \"Класс\"='" + nameClass + "' and \"№ места\"='" + nameSeat+ "'  and \"Инв. №\" is not null");

            dataEquip.Focus();

            btnSetEquip.Enabled = true;
            btnTakeOffEquip.Enabled = false;
            btnTransferEquip.Enabled = false;

            dataEquip_CellClick(sender, new DataGridViewCellEventArgs(0, 0));

        }

        private void dataEquip_CellClick(object sender, DataGridViewCellEventArgs e) {

            txtBoxNote.Text = null;

            if (dataEquip.SelectedRows.Count != 0) {

                btnTakeOffEquip.Enabled = true;
                btnTransferEquip.Enabled = true;

                string numberEquip = dataEquip.SelectedRows[0].Cells[0].Value.ToString();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.con;

                string query = "select distinct \"Примечание оборуд.\" from оборуд_учебного_места " +
                            "where \"Инв. №\"='" + numberEquip + "'";
                cmd.CommandText = query;
                string note =  cmd.ExecuteScalar().ToString();

                txtBoxNote.Text = note;
            }
        }

        private void btnSetEquip_Click(object sender, EventArgs e) {
            
            FormSetEquip form = new FormSetEquip(nameClass, nameWorkstation);
            form.ShowDialog();

            TimerTick(this, new EventArgs());
            cbxSeats_SelectedIndexChanged(this, new EventArgs());

        }

        private void btnTransferEquip_Click(object sender, EventArgs e) {

            if (dataEquip.SelectedRows.Count != 0) {

                string nameInvEquip = dataEquip.SelectedRows[0].Cells[0].Value.ToString();

                FormTransferEquip form = new FormTransferEquip(nameClass, nameWorkstation, nameInvEquip);
                form.ShowDialog();

                TimerTick(this, new EventArgs());
                cbxSeats_SelectedIndexChanged(this, new EventArgs());
            }
        }

        private void btnTakeOffEquip_Click(object sender, EventArgs e) {

            if (dataEquip.SelectedRows.Count != 0) {

                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите снять оборудование?",
                    "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    int condition;
                    DialogResult dialogResult1 = MessageBox.Show("Данное оборудование, исправно?",
                        "Подтверждение", MessageBoxButtons.YesNo);

                    if (dialogResult1 == DialogResult.Yes)
                        condition = 1;
                    else
                    if (dialogResult == DialogResult.No)
                        condition = 0;
                    else
                        return;

                    string nameInvEquip = dataEquip.SelectedRows[0].Cells[0].Value.ToString();

                    DateTime date = DateTime.Now;

                    try {

                        OracleCommand OrCom = Program.con.CreateCommand();
                        // вызов процедуры
                        OrCom.CommandType = CommandType.StoredProcedure;
                        // указываем название процедуры
                        OrCom.CommandText = "ОБСЛУЖИВАНИЕ_КОМП_КЛАССОВ.СНЯТИЕ_ОБОРУДОВАНИЯ";
                        // параметры
                        OrCom.Parameters.Add("инв_номер", OracleDbType.Decimal,
                            nameInvEquip, ParameterDirection.Input);
                        OrCom.Parameters.Add("исправность", OracleDbType.Decimal,
                            condition, ParameterDirection.Input);
                        OrCom.Parameters.Add("дата_снят", OracleDbType.Date,
                           date, ParameterDirection.Input);
                        // выполняем запрос
                        OrCom.ExecuteNonQuery();
                        MessageBox.Show("Транзакция выполнена успешно!");

                        TimerTick(this, new EventArgs());
                        cbxSeats_SelectedIndexChanged(this, new EventArgs());

                    }
                    // обрабатываем ошибки, возникшие при выполнении процедуры
                    catch (OracleException Ex) {
                        // обработка ошибок
                        foreach (OracleError error in Ex.Errors)
                            MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnJournal_Click(object sender, EventArgs e) {
            FormJournal form = new FormJournal();
            form.Show();
        }
    }
}
