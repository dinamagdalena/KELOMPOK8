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
    public partial class controlCheckIn : UserControl
    {
        //create connertion string 
        private string strConnection = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;

        public controlCheckIn()
        {
            InitializeComponent();
        }

        //Method for ckear form
        private void ClearFprm()
        {
            textBoxNamaIn.Text = "";
            textBoxNoKmr.Text = "";
            textBoxNoKtp.Text = "";
            textBoxNoTelp.Text = "";
            textBoxNoKtp.Focus();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            string noktp = textBoxNoKtp.Text;
            string nama = textBoxNamaIn.Text;
            string notelp = textBoxNoTelp.Text;

            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                //Open Gate
                connection.Open();

                //create Query
                string insert = "INSERT INTO TPelanggan (NoKtp, NamaPelanggan, NoTelpPelanggan, JenisKelaminPelanggan) values(@NoKtp, @NamaPelanggan, @NoTelpPelanggan, @JenisKelaminPelanggan) ";
                
                //Isnert Data Into table
                SqlCommand cmd = new SqlCommand(insert, connection);

                //Add Parameter Into CMD
                cmd.Parameters.AddWithValue("@NoKtp", noktp);
                cmd.Parameters.AddWithValue("@NamaPelanggan", nama);
                cmd.Parameters.AddWithValue("@NoTelp", notelp);

                // Execute Data
                int insertResult = cmd.ExecuteNonQuery();

                //Checking insert result
                if (insertResult == 1)
                {
                    MessageBox.Show("CheckIn Berhasil");
                }
                else
                {
                    MessageBox.Show("Checkin gagal silahkan ulangi");
                }

                //close connection
                connection.Close();

            }

        }

    }
}
