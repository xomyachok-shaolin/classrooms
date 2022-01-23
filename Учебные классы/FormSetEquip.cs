using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class FormSetEquip : Form {

        public event EventHandler ButtonClicked;

        private string nameClass, nameWorkstation, nameEquip;

        public FormSetEquip(string nameClass, string nameWorkstation) {
            InitializeComponent();
            DoubleBuffered = true;

            this.nameClass = nameClass;
            this.nameWorkstation = nameWorkstation;
        }

        private void Form1_Add_Load(object sender, EventArgs e) {

            OracleCommand cmd = new OracleCommand();
            // Сочетать Command с Connection.
            cmd.Connection = Program.con;
            cmd.CommandText = "select distinct\"Инв. №\" from журнал_обслуживания where \"Инв. №\" is not null";

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxEquip.Items.Add(reader.GetValue(0).ToString());
                    }
                }
            }
            cbxEquip.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxEquip.AutoCompleteSource = AutoCompleteSource.ListItems;

            btnSet.Enabled = false;

        }

        private void cbxEquip_SelectedIndexChanged(object sender, EventArgs e) {

            nameEquip = cbxEquip.SelectedItem.ToString();

            btnSet.Enabled = true;
            btnSet.Focus();

        }
        private void btnAdd_Click(object sender, EventArgs e) {

            if (cbxEquip.SelectedItem != null) {


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
                    OrCom.CommandText = "ОБСЛУЖИВАНИЕ_КОМП_КЛАССОВ.УСТАНОВКА_ОБОРУДОВАНИЯ";
                    // параметры
                    OrCom.Parameters.Add("инв_номер", OracleDbType.Decimal,
                        nameEquip, ParameterDirection.Input);
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
                MessageBox.Show("Неккоректный ввод инвентарного номера оборудования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
