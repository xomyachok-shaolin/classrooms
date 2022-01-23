using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class Form2_Add : Form {

        public event EventHandler ButtonClicked;

        private string idClass;

        public static string idSeat = "";

        public Form2_Add(string idClass) {
            InitializeComponent();
            DoubleBuffered = true;

            this.idClass = idClass;

            maskedTxtBoxIP.Mask = "###\\.###\\.###\\.###";
            maskedTxtBoxIP.ValidatingType = typeof(System.Net.IPAddress);
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            string idSeat = "";

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
                            OrCom.CommandText = "ОБСЛУЖИВАНИЕ_КОМП_КЛАССОВ.ДОБАВИТЬ_УЧЕБНОЕ_МЕСТО";
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
                        MessageBox.Show("Введите корректный ip-адресс!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
