using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KELOMPOK8
{
    class Login
    {
        private string Username;
        private string Password;
        private string Status;
        private string StrConnection;

        public Login()
        {
            StrConnection = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;
        }

        public bool ProsesLogin(string Username, string Password, string Status)
        {
            this.Username = Username;
            this.Password = Password;
            this.Status = Status;

            bool isLogin = false;

            SqlConnection conn = new SqlConnection(StrConnection);

            using (conn)
            {
                conn.Open();

                string select = "SELECT * FROM TLOGIN WHERE idkaryawan ='"+ Username +"' and password ='" + Password + "' and status = '" + Status + "'";

                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                isLogin = reader.HasRows;

                conn.Close();
            }
            return isLogin;
        }

    }
}
