using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class Form2_Edit : Form {

        public event EventHandler ButtonClicked;

        private string idClass, nameWorkstation;
        public static string idSeat = "";

        public Form2_Edit(string idClass, string nameWorkstation) {
            InitializeComponent();
            DoubleBuffered = true;

            this.idClass = idClass;
            this.nameWorkstation = nameWorkstation;

            maskedTxtBoxIP.Mask = "###\\.###\\.###\\.###";
            maskedTxtBoxIP.ValidatingType = typeof(System.Net.IPAddress);
        }

        private void Form2_Edit_Load(object sender, EventArgs e) {

            txtBoxNameWorkstation.Text = nameWorkstation;

            OracleCommand cmd = new OracleCommand();
            // Сочетать Command с Connection.
            cmd.Connection = Program.con;
            cmd.CommandText = "select номер_учебного_места, ip_адрес, примечание from учебные_места " +
                "where ид_класса ='" + idClass + "' and имя_рабочей_станции='" + nameWorkstation + "'";

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        txtBoxNumberSeat.Text = reader.GetString(0);
                        maskedTxtBoxIP.Text = reader.GetString(1);
                        txtBoxNote.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) {

            if (!txtBoxNumberSeat.Text.Equals("")) {

                string numberSeat = txtBoxNumberSeat.Text;

                if (!txtBoxNameWorkstation.Text.Equals("")) {

                    string nameWorkstation = txtBoxNameWorkstation.Text;

                    if (!maskedTxtBoxIP.Text.Equals("   .   .   .")) {

                        string ipAddress = maskedTxtBoxIP.Text;
                        string note = txtBoxNote.Text;

                        try {
                            OracleCommand OrCom = Program.con.CreateCommand();
                            // вызов процедуры
                            OrCom.CommandType = CommandType.StoredProcedure;
                            // указываем название процедуры
                            OrCom.CommandText = "ОБСЛУЖИВАНИЕ_КОМП_КЛАССОВ.ИЗМЕНИТЬ_УЧЕБНОЕ_МЕСТО";
                            // параметры
                            OrCom.Parameters.Add("класс", OracleDbType.Decimal,
                                idClass, ParameterDirection.Input);
                            OrCom.Parameters.Add("номер_учеб_места", OracleDbType.Varchar2,
                                numberSeat, ParameterDirection.Input);
                            OrCom.Parameters.Add("имя_раб_станции", OracleDbType.Varchar2,
                                nameWorkstation, ParameterDirection.Input);
                            OrCom.Parameters.Add("ip", OracleDbType.Varchar2,
                                ipAddress, ParameterDirection.Input);
                            OrCom.Parameters.Add("примеч", OracleDbType.Varchar2,
                                note, ParameterDirection.Input);
                            OrCom.Parameters.Add("ид_места", OracleDbType.Decimal,
                               idSeat, ParameterDirection.Output);
                            // выполняем запрос
                            OrCom.ExecuteNonQuery();
                            MessageBox.Show("Транзакция выполнена успешно!");

                            idSeat = OrCom.Parameters["ид_места"].Value.ToString();

                            ButtonClicked?.Invoke(this, e);

                            Close();
                        }
                        // обрабатываем ошибки, возникшие при выполнении процедуры
                        catch (OracleException Ex) {
                            // обработка ошибок
                            foreach (OracleError error in Ex.Errors) {
                                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    } else {
                        MessageBox.Show("Введите имя рабочей станции!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("Введите имя рабочей станции!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Введите номер учебного места!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
