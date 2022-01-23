using System;
using System.Windows.Forms;

namespace Учебные_классы {
    public partial class FormEnter : Form {
        public FormEnter() {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e) {

            string user = txtBoxLogin.Text;
            string password = txtBoxPass.Text;

            if (cbxPost.SelectedItem != null) {

                Program.con = Program.GetDBConnection(user, password);

                try {
                    Program.con.Open();

                    Hide();

                    if (cbxPost.SelectedItem.ToString().Equals("Руководитель")) {

                        FormChief form = new FormChief();
                        form.ShowDialog();

                    } else {
                        FormAssistant form = new FormAssistant();
                        form.ShowDialog();
                    }

                    Show();

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Ошибка соединения!", MessageBoxButtons.OK);
                }
            } else
                MessageBox.Show("Выберите вашу должность!", "Ошибка корректности вх. данных!", MessageBoxButtons.OK);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void FormEnter_Load(object sender, EventArgs e) {
            
            txtBoxLogin.Text = "MASS_19";
            txtBoxPass.Text = "Starwars6";

            cbxPost.Focus();
        }
    }
}
