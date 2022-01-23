using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class FormTransferEquip : Form {

        private string nameClass,
                       nameWorkstation,
                       nameInvEquip;

        public FormTransferEquip(string nameClass, string nameWorkstation, string nameInvEquip) {
            InitializeComponent();
            DoubleBuffered = true;

            this.nameClass = nameClass;
            this.nameWorkstation = nameWorkstation;
            this.nameInvEquip = nameInvEquip;
        }

        private void Form1_Add_Load(object sender, EventArgs e) {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con; 
            cmd.CommandText = "select distinct\"Класс\" from оборуд_учебного_места WHERE ид_класса is not null";
            
            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxClass.Items.Add(reader.GetString(0));
                    }
                }
            }

            cbxClass.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxClass.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxNameWorkstation.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxNameWorkstation.AutoCompleteSource = AutoCompleteSource.ListItems;

            btnTransfer.Enabled = false;
        }

        private void cbxClass_SelectedIndexChanged(object sender, EventArgs e) {
            
            nameClass = cbxClass.SelectedItem.ToString();
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = "select distinct \"Имя рабочей станции\" from оборуд_учебного_места " +
                "where \"Класс\"='" + nameClass + "'";

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxNameWorkstation.Items.Add(reader.GetString(0));
                    }
                }
            }

            cbxNameWorkstation.Focus();
        }

        private void cbxNameWorkstation_SelectedIndexChanged(object sender, EventArgs e) {

            nameWorkstation = cbxNameWorkstation.SelectedItem.ToString();
            
            btnTransfer.Enabled = true;
            btnTransfer.Focus();

        }
        private void btnAdd_Click(object sender, EventArgs e) {

            if (cbxClass.SelectedItem != null && cbxNameWorkstation.SelectedItem != null) {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.con;

                cmd.CommandText = "select ид_класса from журнал_обслуживания ум where ум.\"Класс\" ='" + nameClass + "'";
                string idClass = cmd.ExecuteScalar().ToString();

                DateTime date = DateTime.Now;

                try {

                    OracleCommand OrCom = Program.con.CreateCommand();
                    // вызов процедуры
                    OrCom.CommandType = CommandType.StoredProcedure;
                    // указываем название процедуры
                    OrCom.CommandText = "ОБСЛУЖИВАНИЕ_КОМП_КЛАССОВ.ПЕРЕМЕЩЕНИЕ_ОБОРУДОВАНИЯ";
                    // параметры
                    OrCom.Parameters.Add("инв_номер", OracleDbType.Decimal,
                        nameInvEquip, ParameterDirection.Input);
                    OrCom.Parameters.Add("класс", OracleDbType.Decimal,
                        idClass, ParameterDirection.Input);
                    OrCom.Parameters.Add("имя_раб_станции", OracleDbType.Varchar2,
                        nameWorkstation, ParameterDirection.Input);
                    OrCom.Parameters.Add("дата_устан", OracleDbType.Date,
                       date, ParameterDirection.Input);
                    // выполняем запрос
                    OrCom.ExecuteNonQuery();
                    MessageBox.Show("Транзакция выполнена успешно!");

                    Close();
                }
                // обрабатываем ошибки, возникшие при выполнении процедуры
                catch (OracleException Ex) {
                    // обработка ошибок
                    foreach (OracleError error in Ex.Errors)
                        MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else 
                MessageBox.Show("Неккоректный ввод местоположения для перемещения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
