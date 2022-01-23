using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class FormChief : Form {
        public FormChief() {
            InitializeComponent(); 
            DoubleBuffered = true;
        }

        private string division = "", 
                       idClass = "",
                       nameClass = "",
                       nameWorkstation = "",
                       nameInvEquip = "",
                       idClassTab2 = "",
                       nameClassJournal = "",
                       nameSeatJournal = "";

        private string filtrQueryTab1 = "select \"Адрес\",\"Телефон\",\"Макс. мест\",\"Факт.мест\",\"Испр.мест\"" +
                "from учебные_классы where \"Ответств кафедра\"='",
                       filtrQueryTab3 = "select distinct ум.\"Инв. №\",ум.\"Тип\",ум.\"Характеристика\",ум.\"Исправность оборуд.\", " +
                        "ум.\"Класс/место\" from оборуд_учебного_места ум where ум.\"Инв. №\" is not null";

        private void Form1_Load(object sender, EventArgs e) {
            
            Timer timer = new Timer();
            timer.Interval = (30 * 1000); // 30 secs
            timer.Tick += new EventHandler(TimerTick);
            timer.Start();
            TimerTick(this,new EventArgs());


            cbxDivisions.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxDivisions.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxClasses.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxClasses.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxClassesJournal.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxClassesJournal.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxSeatsJournal.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxSeatsJournal.AutoCompleteSource = AutoCompleteSource.ListItems;

            btnFilter1.Enabled = true;
            btnFilter2.Enabled = false;
        }

        public void TimerTick(object sender, EventArgs e) {
            //refresh here...
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;

            switch (tabControl.SelectedIndex) {

                case 0:

                    cmd.CommandText = "select distinct\"Ответств кафедра\" from учебные_классы";

                    cbxDivisions.Items.Clear();

                    using (DbDataReader reader = cmd.ExecuteReader()) {
                        if (reader.HasRows) {

                            lblDivision.Text = reader.GetName(0);

                            while (reader.Read())
                                cbxDivisions.Items.Add(reader.GetString(0));
                        }
                    }

                    if (cbxDivisions.SelectedItem != null)
                        dataClasses.DataSource = GetData(filtrQueryTab1 +
                        division + "' GROUP BY \"Адрес\",\"Телефон\",\"Макс. мест\",\"Факт.мест\",\"Испр.мест\",\"Необоруд.мест\"");

                    break;
                
                case 1:

                    cmd.CommandText = "select distinct\"Класс\" from оборуд_учебного_места WHERE ид_класса is not null";

                    cbxClasses.Items.Clear();

                    using (DbDataReader reader = cmd.ExecuteReader()) {
                        if (reader.HasRows) {

                            lblClassTab2.Text = reader.GetName(0);

                            while (reader.Read())
                                cbxClasses.Items.Add(reader.GetString(0));
                        }
                    }

                    if (cbxClasses.SelectedItem != null) {
                     
                        dataSeats.DataSource = GetData("select distinct ум.\"№ места\", ум.\"Имя рабочей станции\", " +
                            "ум.\"IP-адрес\", ум.\"Исправность места\" from оборуд_учебного_места ум where ум.\"Класс\" = '"
                            + nameClass + "' and ум.\"№ места\" is not null");

                        if (dataSeats.SelectedRows.Count != 0)

                            dataEquipTab2.DataSource = GetData("select ум.\"Инв. №\",ум.\"Тип\",ум.\"Характеристика\",ум.\"Исправность оборуд.\" " +
                                "from оборуд_учебного_места ум where ум.\"Класс\" = '" + nameClass +
                                "' and ум.\"Имя рабочей станции\" = '" + nameWorkstation + "' and ум.\"Инв. №\" is not null");
                    }

                    break;
                case 2:

                    dataEquipTab3.DataSource = GetData(filtrQueryTab3);

                    dataEquipTab3.Focus();

                    break;
                case 3:

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

                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            Close();
        }

        private DataTable GetData(string query) {

            DataTable dataTable = new DataTable();

            OracleCommand cmd = new OracleCommand(query);

            cmd.CommandType = CommandType.Text;

            cmd.Connection = Program.con;

            switch (tabControl.SelectedIndex) {

                case 0:

                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter()) {
                        dataAdapter.SelectCommand = cmd;
                        dataAdapter.Fill(dataTable);
                    }

                    break;
                case 1: case 2:

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
                                                 : i == 4 ?
                                reader[i].ToString().Equals("  , / ") ?  
                                           "" : reader[i]
                                              : reader[i];
                        }

                        dataTable.Rows.Add(dataRow);
                    }

                    break;
                case 3:

                    OracleDataReader reader4 = cmd.ExecuteReader();
                    DataTable dtSchema4 = reader4.GetSchemaTable();
                    List<DataColumn> listCols4 = new List<DataColumn>();

                    if (dtSchema4 != null) {
                        foreach (DataRow drow in dtSchema4.Rows) {
                            string columnName = Convert.ToString(drow["ColumnName"]);
                            DataColumn column = new DataColumn(columnName, (Type)drow["DataType"]);
                            listCols4.Add(column);
                            dataTable.Columns.Add(column);
                        }
                    }

                    listCols4[5].DataType = typeof(bool);

                    // Read rows from DataReader and populate the DataTable 
                    while (reader4.Read()) {
                        DataRow dataRow = dataTable.NewRow();

                        for (int i = 0; i < listCols4.Count; i++) {
                            dataRow[listCols4[i]] = i == 5 ?
                                reader4[i].ToString().Equals("1") ?
                                    "true" : "false"
                                              : reader4[i];
                        }

                        dataTable.Rows.Add(dataRow);
                    }

                    break;
            }

            return dataTable;
        }

        private void CbxDivisions_SelectedIndexChanged(object sender, EventArgs e) {
            
            string address = "";
            bool isTransaction = false;

            if (cbxDivisions.SelectedItem == null) {

                if (Form1_Edit.idClass.Length == 0)
                    return;

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.con;

                cmd.CommandText = "select \"Ответств кафедра\" from учебные_классы where ид_класса = '" + Form1_Edit.idClass + "'";
                division = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "select \"Адрес\" from учебные_классы where ид_класса = '" + Form1_Edit.idClass + "'";
                address = cmd.ExecuteScalar().ToString();

                isTransaction = true;

            } else
                division = cbxDivisions.SelectedItem.ToString();

            dataClasses.DataSource = GetData(filtrQueryTab1 + 
                division + "' GROUP BY \"Адрес\",\"Телефон\",\"Макс. мест\",\"Факт.мест\",\"Испр.мест\",\"Необоруд.мест\"");

            if (isTransaction) {
                foreach (DataGridViewRow Row in dataClasses.Rows)
                    if (Row.Cells[0].Value.ToString().Equals(address)) {
                        dataClasses.CurrentCell = Row.Cells[0];
                        break;
                    }
                
            }
            dataClasses.Focus();

            DataClasses_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void BtnAdd_Click(object sender, EventArgs e) {

            Form1_Add formAdd = new Form1_Add();

            formAdd.ButtonClicked += TimerTick;

            formAdd.ShowDialog();
        }

        private void DataClasses_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (dataClasses.SelectedRows.Count != 0) {
                string addr = dataClasses.SelectedRows[0].Cells[0].Value.ToString();
                
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.con;

                string query = "select \"Примечание\" from учебные_классы where \"Адрес\" = '" + addr + "'";
                cmd.CommandText = query;
                string note =  cmd.ExecuteScalar().ToString();

                txtBoxNoteClass.Text = note;

                btnEdit.Enabled = true;
            }
        }
        
        private void BtnEdit_Click(object sender, EventArgs e) {
            string addr = dataClasses.SelectedRows[0].Cells[0].Value.ToString();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;

            string query = "select ид_класса from учебные_классы where \"Адрес\" = '" + addr + "'";
            cmd.CommandText = query;
            idClass =  cmd.ExecuteScalar().ToString();

            Form1_Edit formEdit = new Form1_Edit(idClass);

            formEdit.ButtonClicked += TimerTick;
            formEdit.ButtonClicked += CbxDivisions_SelectedIndexChanged;
            
            formEdit.ShowDialog();
            dataClasses.Focus();
        }

        private void BtnFilter2_Click(object sender, EventArgs e) {
            btnFilter2.Enabled = false;
            btnFilter1.Enabled = true;

            filtrQueryTab1 = "select \"Адрес\",\"Телефон\",\"Макс. мест\",\"Факт.мест\",\"Испр.мест\"" +
                "from учебные_классы where \"Ответств кафедра\"='";

            CbxDivisions_SelectedIndexChanged(this, new EventArgs());
            dataClasses.Focus();
        }

        private void BtnFilter1_Click(object sender, EventArgs e) {
            btnFilter1.Enabled = false;
            btnFilter2.Enabled = true;

            filtrQueryTab1 = "select \"Адрес\",\"Телефон\",\"Макс. мест\",\"Факт.мест\",\"Необоруд.мест\"" +
                "from учебные_классы where \"Ответств кафедра\"='";

            CbxDivisions_SelectedIndexChanged(this, new EventArgs());
            dataClasses.Focus();
        }

        /* События по Учебным местам */
        private void CbxClasses_SelectedIndexChanged(object sender, EventArgs e) {

            bool isTransaction = false;

            if (cbxClasses.SelectedItem == null || cbxClasses.Items.Contains(Text)) {

                string idSeat = Form2_Add.idSeat.Length == 0 ? 
                    Form2_Edit.idSeat.Length  == 0 ? 
                         Form2_Edit.idSeat 
                            : "" 
                         : Form2_Add.idSeat;

                nameClass = cbxClasses.Text;

                if (idSeat != "") {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = Program.con;

                    cmd.CommandText = "select имя_рабочей_станции from учебные_места where ид='" + idSeat + "'";
                    nameWorkstation = cmd.ExecuteScalar().ToString();

                    isTransaction = true;
                }

            } else
                nameClass = cbxClasses.SelectedItem.ToString();

            btnAdd2.Enabled = true;

            dataSeats.DataSource = GetData("select distinct ум.\"№ места\",ум.\"Имя рабочей станции\",ум.\"IP-адрес\", ум.\"Исправность места\" " +
                            "from оборуд_учебного_места ум " +
                            "where ум.\"Класс\" ='" + nameClass + "' and ум.\"Имя рабочей станции\" is not null");


            if (isTransaction) {
                foreach (DataGridViewRow Row in dataSeats.Rows)
                    if (Row.Cells[1].Value.ToString().Equals(nameWorkstation)) {
                        dataSeats.CurrentCell = Row.Cells[0];
                        break;
                    }

            }

            dataSeats.Focus();

            DataSeats_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void DataSeats_CellClick(object sender, DataGridViewCellEventArgs e) {

            dataEquipTab2.DataSource = null;
            txtBoxNoteSeat.Text = null;

            if (dataSeats.SelectedRows.Count != 0) {

                btnEdit2.Enabled = true;
                btnDelete2.Enabled = true;
                
                nameWorkstation = dataSeats.SelectedRows[0].Cells[1].Value.ToString();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.con;

                string query = "select \"Примечание места\" from оборуд_учебного_места ум where \"Класс\" = '" + nameClass +
                               "' and \"Имя рабочей станции\" = '" + nameWorkstation  + "'";
                cmd.CommandText = query;
                string note =  cmd.ExecuteScalar().ToString();

                txtBoxNoteSeat.Text = note;

                dataEquipTab2.DataSource = GetData("select ум.\"Инв. №\",ум.\"Тип\",ум.\"Характеристика\",ум.\"Исправность оборуд.\" " +
                    "from оборуд_учебного_места ум where ум.\"Класс\" = '" + nameClass + 
                    "' and ум.\"Имя рабочей станции\" = '" + nameWorkstation + "' and ум.\"Инв. №\" is not null");

                // btnEdit.Enabled = true;
            }
        }

        private void btnAdd2_Click(object sender, EventArgs e) {

            if (cbxClasses.SelectedItem != null || !cbxClasses.Items.Contains(Text)) {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.con;

                string query = "select ид_класса from оборуд_учебного_места ум where ум.\"Класс\" ='" + nameClass + "'";
                cmd.CommandText = query;
                idClassTab2 = cmd.ExecuteScalar().ToString();

                Form2_Add formAdd = new Form2_Add(idClassTab2);

                formAdd.ButtonClicked += TimerTick;
                formAdd.ButtonClicked += CbxClasses_SelectedIndexChanged;

                formAdd.ShowDialog();

            } else {
                MessageBox.Show("Выберите класс, в который хотите добавить учебное место!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit2_Click(object sender, EventArgs e) {

            if (dataSeats.SelectedRows.Count != 0) {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.con;

                cmd.CommandText = "select ид_класса from оборуд_учебного_места ум where ум.\"Класс\" ='" + nameClass + "'";
                idClassTab2 = cmd.ExecuteScalar().ToString();

                nameWorkstation = dataSeats.SelectedRows[0].Cells[1].Value.ToString();

                Form2_Edit formEdit = new Form2_Edit(idClassTab2, nameWorkstation);

                formEdit.ButtonClicked += TimerTick;
                formEdit.ButtonClicked += CbxClasses_SelectedIndexChanged;

                formEdit.ShowDialog();
            }
        }
        private void btnDelete2_Click(object sender, EventArgs e) {

            if (dataSeats.SelectedRows.Count != 0) {

                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить учебное место?", 
                "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = Program.con;

                    cmd.CommandText = "select ид_класса from оборуд_учебного_места ум where ум.\"Класс\" ='" + nameClass + "'";
                    idClassTab2 = cmd.ExecuteScalar().ToString();

                    nameWorkstation = dataSeats.SelectedRows[0].Cells[1].Value.ToString();

                    DateTime date = DateTime.Now;

                    try {

                        OracleCommand OrCom = Program.con.CreateCommand();
                        // вызов процедуры
                        OrCom.CommandType = CommandType.StoredProcedure;
                        // указываем название процедуры
                        OrCom.CommandText = "ОБСЛУЖИВАНИЕ_КОМП_КЛАССОВ.УДАЛИТЬ_УЧЕБНОЕ_МЕСТО";
                        // параметры
                        OrCom.Parameters.Add("класс", OracleDbType.Decimal,
                            idClassTab2, ParameterDirection.Input);
                        OrCom.Parameters.Add("имя_раб_станции", OracleDbType.Varchar2,
                            nameWorkstation, ParameterDirection.Input);
                        OrCom.Parameters.Add("дата_снят", OracleDbType.Date,
                           date, ParameterDirection.Output);
                        // выполняем запрос
                        OrCom.ExecuteNonQuery();
                        MessageBox.Show("Транзакция выполнена успешно!");

                        TimerTick(this, new EventArgs());
                        CbxClasses_SelectedIndexChanged(this, new EventArgs());

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

        /* События по оборудованию */
        private void dataEquipTab3_CellClick(object sender, DataGridViewCellEventArgs e) {

            txtBoxNoteEquipTab3.Text = null;
            
            if (dataEquipTab3.SelectedRows.Count != 0) {

                nameInvEquip = dataEquipTab3.SelectedRows[0].Cells[0].Value.ToString();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.con;

                string query = "select \"Примечание оборуд.\" from оборуд_учебного_места ум " +
                               "where  ум.\"Инв. №\" = '" + nameInvEquip + "'";

                cmd.CommandText = query;
                string note =  cmd.ExecuteScalar().ToString();

                txtBoxNoteEquipTab3.Text = note;
            }
        }
        private void btnDeregister_Click(object sender, EventArgs e) {

            if (dataEquipTab3.SelectedRows.Count != 0) {

                nameInvEquip = dataEquipTab3.SelectedRows[0].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите снять оборудование с учета?",
                "Подтверждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {

                    try {

                        OracleCommand OrCom = Program.con.CreateCommand();
                        // вызов процедуры
                        OrCom.CommandType = CommandType.StoredProcedure;
                        // указываем название процедуры
                        OrCom.CommandText = "ОБСЛУЖИВАНИЕ_КОМП_КЛАССОВ.СНЯТИЕ_ОБОРУДОВАНИЯ_С_УЧЕТА";
                        // параметры
                        OrCom.Parameters.Add("инв_номер", OracleDbType.Decimal,
                            nameInvEquip, ParameterDirection.Input);
                        // выполняем запрос
                        OrCom.ExecuteNonQuery();
                        MessageBox.Show("Транзакция выполнена успешно!");

                        TimerTick(this, new EventArgs());

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
        private void btnFilterEquip_CheckedChanged(object sender, EventArgs e) {
            if (btnFilterEquip.Checked)
                filtrQueryTab3 = "select distinct ум.\"Инв. №\",ум.\"Тип\",ум.\"Характеристика\",ум.\"Исправность оборуд.\", " +
                        "ум.\"Класс/место\" from оборуд_учебного_места ум where ум.\"Инв. №\" is not null and ум.\"Исправность оборуд.\" = '0'";
            else
                filtrQueryTab3 = "select distinct ум.\"Инв. №\",ум.\"Тип\",ум.\"Характеристика\",ум.\"Исправность оборуд.\", " +
                        "ум.\"Класс/место\" from оборуд_учебного_места ум where ум.\"Инв. №\" is not null";

            TimerTick(this, new EventArgs());

        }

        /* События по журналу обслуживания */
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

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e) {
            TimerTick(this, new EventArgs());
        }
    }
}
