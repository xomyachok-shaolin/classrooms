using Oracle.DataAccess.Client;
using System;
using System.Windows.Forms;

namespace Учебные_классы {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormEnter());
        }

        public static OracleConnection con;

        public static OracleConnection GetDBConnection(String user, String password) {

            string host = "oti.ru";
            int port = 1521;
            string sid = "alfa";

            // 'Connection String' подключается напрямую к Oracle.
            string connString = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = "
                 + host + ")(PORT = " + port + "))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = "
                 + sid + ")));Password=" + password + ";User ID=" + user;


            OracleConnection con = new OracleConnection();

            con.ConnectionString = connString;

            return con;
        }
    }
}
