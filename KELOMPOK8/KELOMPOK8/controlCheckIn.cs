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
        private string NoKTP;
        private string NamaPelanggan;
        private string NoTelpPelanggan;
        private string JenisKelaminPelanggan;
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
            JenisKelaminPelanggan = (sender as RadioButton).Text;
        }

        private void radioButtonPere_CheckedChanged(object sender, EventArgs e)
        {
            JenisKelaminPelanggan = (sender as RadioButton).Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kategori = (sender as ComboBox).Text;
            //if (kategori == "Superior")
           // { Id_kategori = }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            NoKTP = textBoxNoKtp.Text;
            NamaPelanggan = textBoxNamaIn.Text;
            NoTelpPelanggan = textBoxNoTelp.Text;
            no_kmr = textBoxNoKmr.Text;

            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                //Open Gate
                connection.Open();

                //create Query
                string insert = "INSERT INTO TPelanggan (NoKTP, NamaPelanggan, NoTelpPelanggan, JenisKelaminPelanggan) values(@NoKTP, @NamaPelanggan, @NoTelpPelanggan, @JenisKelaminPelanggan) ";

                //Isnert Data Into table
                SqlCommand cmd = new SqlCommand(insert, connection);

                //Add Parameter Into CMD
                cmd.Parameters.AddWithValue("@NoKTP", NoKTP);
                cmd.Parameters.AddWithValue("@NamaPelanggan", NamaPelanggan);
                cmd.Parameters.AddWithValue("@NoTelpPelanggan", NoTelpPelanggan);
                cmd.Parameters.AddWithValue("@JenisKelaminPelanggan", JenisKelaminPelanggan);

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
