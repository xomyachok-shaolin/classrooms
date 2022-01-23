using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class Form1_Edit : Form {
        
        public static string idClass = "";

        public event EventHandler ButtonClicked;

        public Form1_Edit(string idClass) {
            InitializeComponent();
            DoubleBuffered = true;

            Form1_Edit.idClass = idClass;
        }

        private void Form1_Edit_Load(object sender, EventArgs e) {
            OracleCommand cmd = new OracleCommand();
            // Сочетать Command с Connection.
            cmd.Connection = Program.con;
            cmd.CommandText = "select наименование from отделы";

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxDivisions.Items.Add(reader.GetString(0));
                    }
                }
            }
            cbxDivisions.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxDivisions.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmd.CommandText = "select \"Ответств кафедра\" from учебные_классы where ид_класса = '" + idClass + "'"; ;
            string nameClass =  cmd.ExecuteScalar().ToString();
            cbxDivisions.Text = nameClass;

            cmd.CommandText = "select \"Макс. мест\" from учебные_классы where ид_класса = '" + idClass + "'"; ;
            string quantitySeat =  cmd.ExecuteScalar().ToString();
            numUDQuantitySeats.Text = quantitySeat;

            cmd.CommandText = "select \"Примечание\" from учебные_классы where ид_класса = '" + idClass + "'"; ;
            string note =  cmd.ExecuteScalar().ToString();
            txtBoxNote.Text = note;
        }

        private void btnEdit_Click(object sender, EventArgs e) {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;

            if (cbxDivisions.Items.Contains(cbxDivisions.Text)) {

                string nameDivision = cbxDivisions.Text;
                string query = "select ид from отделы where наименование = '" + nameDivision + "'";
                cmd.CommandText = query;
                string idDivision =  cmd.ExecuteScalar().ToString();

                string max_quantity_seat = numUDQuantitySeats.Value.ToString();
                string note = txtBoxNote.Text;

                try {
                    OracleCommand OrCom = Program.con.CreateCommand();
                    // вызов процедуры
                    OrCom.CommandType = CommandType.StoredProcedure;
                    // указываем название процедуры
                    OrCom.CommandText = "ОБСЛУЖИВАНИЕ_КОМП_КЛАССОВ.ИЗМЕНИТЬ_УЧЕБНЫЙ_КЛАСС";
                    // параметры
                    OrCom.Parameters.Add("класс", OracleDbType.Decimal,
                        idClass, ParameterDirection.Input);
                    OrCom.Parameters.Add("ответств_кафедра", OracleDbType.Decimal,
                        idDivision, ParameterDirection.Input);
                    OrCom.Parameters.Add("макс_колво_мест", OracleDbType.Decimal,
                        max_quantity_seat, ParameterDirection.Input);
                    // возвращаемое значение процедуройт - ИД_обслуживания
                    OrCom.Parameters.Add("примечание", OracleDbType.Varchar2,
                        note, ParameterDirection.Input);
                    // выполняем запрос
                    OrCom.ExecuteNonQuery();
                    MessageBox.Show("Транзакция выполнена успешно!");


                    ButtonClicked?.Invoke(sender, e);

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
                MessageBox.Show("Некорректный ввод ответственной кафедры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
