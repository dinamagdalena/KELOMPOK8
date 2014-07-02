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
        private string noktp;
        private string nama;
        private string notelp;
        private string jenis_kelamin;
        private string no_kmr;
        private int Id_kategori;

        public controlCheckIn()
        {
            InitializeComponent();
        }

        //Method for ckear form
        private void ClearForm()
        {
            textBoxNamaIn.Text = "";
            textBoxNoKmr.Text = "";
            textBoxNoKtp.Text = "";
            textBoxNoTelp.Text = "";
            textBoxNoKtp.Focus();
        }

        private void radioButtonLaki_CheckedChanged(object sender, EventArgs e)
        {
            jenis_kelamin = (sender as RadioButton).Text;
        }

        private void radioButtonPere_CheckedChanged(object sender, EventArgs e)
        {
            jenis_kelamin = (sender as RadioButton).Text;
        }

        private void radioButtonStd_CheckedChanged(object sender, EventArgs e)
        {
            Id_kategori = 1;
        }

        private void radioButtonSpr_CheckedChanged(object sender, EventArgs e)
        {
            Id_kategori = 2;
        }

        private void radioButtonDlx_CheckedChanged(object sender, EventArgs e)
        {
            Id_kategori = 3;
        }

        private void radioButtonPrs_CheckedChanged(object sender, EventArgs e)
        {
            Id_kategori = 4;
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            noktp = textBoxNoKtp.Text;
            nama = textBoxNamaIn.Text;
            notelp = textBoxNoTelp.Text;
            no_kmr = textBoxNoKmr.Text;

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
                cmd.Parameters.AddWithValue("@JenisKelaminPelanggan", jenis_kelamin);

                // Execute Data
                int insertResult = cmd.ExecuteNonQuery();

                //Checking insert result
                if (insertResult == 1)
                {
                    MessageBox.Show("Check In Berhasil");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Check in gagal silahkan ulangi");
                }

                

                //close connection
                connection.Close();

            }

        }

    }
}
