using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace KELOMPOK8
{
    public partial class controlLogin : UserControl
    {
        private string strconn = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;

        private string stat;
        private string idkaryawan; 
        public controlLogin()
        {
            InitializeComponent();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            stat = comboBoxStatus.Text;
        }

        private void dataGVLogin_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGVLogin.SelectedRows)
            {
                idkaryawan = row.Cells[0].Value.ToString();
                string password = row.Cells[1].Value.ToString();
                string status = row.Cells[2].Value.ToString();

                textBoxUser.Text = idkaryawan;
                textBoxPass.Text = password;
                stat = status;

 
            }
        }

        private void ResetForm()
        {
            textBoxUser.Text = "";
            textBoxPass.Text = "";
        }

        private void BindDataBase()
        {
            SqlConnection conn = new SqlConnection(strconn);

            using (conn)
            {
                //open the gate
                conn.Open();

                //mebuat perintah sql
                string select = "SELECT * FROM tlogin";

                //select data
                SqlCommand cmd = new SqlCommand(select,conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //load reader into table
                DataTable table = new DataTable();
                table.Load(reader);

                //bind data into data grid view
                dataGVLogin.DataSource = table;
                dataGVLogin.ClearSelection();

                ResetForm();

                //close the gate
                conn.Close();
            }
 
        }

        private void controlLogin_Load(object sender, EventArgs e)
        {
            //panggil bind database
            BindDataBase();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string idkaryawan = textBoxUser.Text;
            string password = textBoxPass.Text;
            string status = stat;

            SqlConnection conn = new SqlConnection(strconn);
            using (conn)
            {
                //open the gate
                conn.Open();

                //membuat perintah sql
                string insert = "INSERT INTO tlogin (password, status, idkaryawan) values (@password, @status, @idkaryawan)";

                //insert data ke table
                SqlCommand cmd = new SqlCommand(insert, conn);

                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@idkaryawan", idkaryawan);

                //execute data
                cmd.ExecuteNonQuery();

                //close the gate
                conn.Close();

                //refresh
                BindDataBase();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string password = textBoxPass.Text;
            string status = stat;

            SqlConnection conn = new SqlConnection(strconn);
            using (conn)
            {
                //open the gate
                conn.Open();

                //membuat perintah sql
                string insert = "UPDATE tlogin SET password = @password, status = @status WHERE idkaryawan = @idkaryawan";

                //insert data ke table
                SqlCommand cmd = new SqlCommand(insert, conn);

                
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@idkaryawan", idkaryawan);

                //execute data
                cmd.ExecuteNonQuery();

                //close the gate
                conn.Close();

                //refresh
                BindDataBase();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string judul = "Pesan Konfirmasi";
            string pesan = "Apakah Anda Yakin Nama " + username.Trim() + " Akan Dihapus ??";
            DialogResult result = MessageBox.Show(pesan, judul, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //result = cancel
            if (result != DialogResult.OK)
            {
                //cancel delete
                return;
            }

            SqlConnection conn = new SqlConnection(strconn);
            using (conn)
            {
                //open the gate
                conn.Open();

                //membuat perintah sql
                string insert = "DELETE FROM tkaryawan WHERE idkaryawan = @idkaryawan";

                //insert data into table
                SqlCommand cmd = new SqlCommand(insert, conn);

                //add parametes to cmd
                cmd.Parameters.AddWithValue("@idkaryawan", idkaryawan);

                //execute data
                cmd.ExecuteNonQuery();

                //close teh gate
                conn.Close();

                //refresh
                BindDataBase();
            }
        }
    }
}
