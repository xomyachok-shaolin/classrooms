using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class Form1_Add : Form {

        public event EventHandler ButtonClicked;

        public Form1_Add() {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Form1_Add_Load(object sender, EventArgs e) {
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

            cmd.CommandText = "select distinct префикс_улицы from адреса";

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxAddress1.Items.Add(reader.GetString(0));
                    }
                }
            }
            cbxAddress1.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxAddress1.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            cbxAddress2.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxAddress2.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxAddress3.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxAddress3.AutoCompleteSource = AutoCompleteSource.ListItems;

            cbxAddress4.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxAddress4.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cbxAddress1_SelectedIndexChanged(object sender, EventArgs e) {
            string val = cbxAddress1.SelectedItem.ToString();
            string query = "select distinct улица from адреса where префикс_улицы = '" + val + "'";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = query;

            cbxAddress2.Text = "";
            cbxAddress2.Items.Clear();
            cbxAddress3.Text = "";
            cbxAddress3.Items.Clear();
            cbxAddress4.Text = "";
            cbxAddress4.Items.Clear();

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxAddress2.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void cbxAddress2_SelectedIndexChanged(object sender, EventArgs e) {

            string val = cbxAddress2.SelectedItem.ToString();
            string query = "select distinct дом from адреса where  улица = '" + val + "'";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = query;

            cbxAddress3.Text = "";
            cbxAddress3.Items.Clear();
            cbxAddress4.Text = "";
            cbxAddress4.Items.Clear();

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxAddress3.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void cbxAddress3_SelectedIndexChanged(object sender, EventArgs e) {
            string house = cbxAddress3.SelectedItem.ToString();
            string street = cbxAddress2.SelectedItem.ToString();
            string query = "select distinct помещение from адреса " +
                "where улица = '" + street + "' and " +
                        "дом = '" + house + "'";

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;
            cmd.CommandText = query;

            cbxAddress4.Text = "";
            cbxAddress4.Items.Clear();

            using (DbDataReader reader = cmd.ExecuteReader()) {
                if (reader.HasRows) {
                    while (reader.Read()) {
                        cbxAddress4.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.con;

            if (cbxDivisions.Items.Contains(cbxDivisions.Text)) {

                string nameDivision = cbxDivisions.Text;
                string query = "select ид from отделы where наименование = '" + nameDivision + "'";
                cmd.CommandText = query;

                string idDivision =  cmd.ExecuteScalar().ToString();

                if (cbxAddress1.Items.Contains(cbxAddress1.Text) &&
                    cbxAddress2.Items.Contains(cbxAddress2.Text) &&
                    cbxAddress3.Items.Contains(cbxAddress3.Text) &&
                    cbxAddress4.Items.Contains(cbxAddress4.Text)) {

                    string street = cbxAddress2.Text;
                    string house = cbxAddress3.Text;
                    string room = cbxAddress4.Text;
                    string max_quantity_seat = numUDQuantitySeats.Value.ToString();
                    string note = txtBoxNote.Text;

                    try {
                        OracleCommand OrCom = Program.con.CreateCommand();
                        // вызов процедуры
                        OrCom.CommandType = CommandType.StoredProcedure;
                        // указываем название процедуры
                        OrCom.CommandText = "ОБСЛУЖИВАНИЕ_КОМП_КЛАССОВ.ДОБАВИТЬ_УЧЕБНЫЙ_КЛАСС";
                        // параметры
                        OrCom.Parameters.Add("н_улицы", OracleDbType.Varchar2,
                            street, ParameterDirection.Input);
                        OrCom.Parameters.Add("н_дома", OracleDbType.Varchar2,
                            house, ParameterDirection.Input);
                        OrCom.Parameters.Add("н_помещения", OracleDbType.Varchar2,
                            room, ParameterDirection.Input);
                        OrCom.Parameters.Add("ответств_кафедра", OracleDbType.Decimal,
                            idDivision, ParameterDirection.Input);
                        OrCom.Parameters.Add("макс_колво_мест", OracleDbType.Decimal,
                            max_quantity_seat, ParameterDirection.Input);
                        OrCom.Parameters.Add("примечание", OracleDbType.Varchar2,
                            note, ParameterDirection.Input);
                        // выполняем запрос
                        OrCom.ExecuteNonQuery();
                        MessageBox.Show("Транзакция выполнена успешно!");

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
                    MessageBox.Show("Некорректный ввод адреса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Некорректный ввод ответственной кафедры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
