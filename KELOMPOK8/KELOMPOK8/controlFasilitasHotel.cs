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
    public partial class controlFasilitasHotel : UserControl
    {
       // private string Id;
        string strConnection = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;
        public controlFasilitasHotel()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            textBoxIdFasilitasHotel.Text = "";
            textBoxNamaFasilitasHotel.Text = "";
            textBoxHargaFasilitasHotel.Text = "";
            textBoxIdFasilitasHotel.Focus();
        }

        private void BindDatabase()
        {
            // buat Sql Connection
            SqlConnection connection = new SqlConnection(strConnection);

            // Select Data menggunakan Connection
            using (connection)
            {
                // buka gerbang
                connection.Open();

                // buat String Sql Statement
                string select = "SELECT * FROM tfasilitashotel";

                // Select Data
                SqlCommand cmd = new SqlCommand(select, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                // isikan Reader kedalam Table
                DataTable table = new DataTable();
                table.Load(reader);

                // bind table ke Datagridview
                dataGVFasilitasHotel.DataSource = table;

                // clear selection In Form
                dataGVFasilitasHotel.ClearSelection();

                // reset form
                ResetForm();

                // tutup gerbang
                connection.Close();
            }
        }
        private void controlFasilitasHotel_Load(object sender, EventArgs e)
        {
            // Call BindDatabase Method
            BindDatabase();
        }
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string IdFasilitasHotel = textBoxIdFasilitasHotel.Text;
            string NamaFasilitasHotel = textBoxNamaFasilitasHotel.Text;
            string HargaFasilitasHotel = textBoxHargaFasilitasHotel.Text;
            
            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                // buka gerbang
                connection.Open();

                // buat Insert Sql Query Statement
                string insert = "INSERT INTO tfasilitashotel(idfasilitashotel, namafasilitashotel, hargafasilitashotel,) values (@idfasilitashotel, @namafasilitashotel, @hargafasilitashotel)";

                // Insert Data kedalam Table
                SqlCommand cmd = new SqlCommand(insert, connection);

                // tambahkan Parameter kedalam Cmd
                cmd.Parameters.AddWithValue("@idfasilitashotel", IdFasilitasHotel);
                cmd.Parameters.AddWithValue("@namafasilitashotel", NamaFasilitasHotel);
                cmd.Parameters.AddWithValue("@hargafasilitashotel", HargaFasilitasHotel);

                // execute data
                int insertResult = cmd.ExecuteNonQuery();

                // check Query Command
                if (insertResult == 1)
                {
                    MessageBox.Show("Berhasil");
                }
                else
                {
                    MessageBox.Show("Gagal");
                }

                // tutup gerbang
                connection.Close();

                // refresh
                BindDatabase();
            }
        }
        private void dataGVFasilitasHotel_SelectionChanged(object sender, EventArgs e)
        {
            // Detect User Selection
            foreach (DataGridViewRow row in dataGVFasilitasHotel.SelectedRows)
            {
                string IdFasilitasHotel = row.Cells[0].Value.ToString();
                string NamaFasilitasHotel = row.Cells[1].Value.ToString();
                string HargaFasilitasHotel = row.Cells[2].Value.ToString();
                //string Id_Fasilitas = row.Cells[3].Value.ToString();

                textBoxIdFasilitasHotel.Text = IdFasilitasHotel;
                textBoxNamaFasilitasHotel.Text = NamaFasilitasHotel;
                textBoxHargaFasilitasHotel.Text = HargaFasilitasHotel;
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            string IdFasilitasHotel = textBoxIdFasilitasHotel.Text;
            string NamaFasilitasHotel = textBoxNamaFasilitasHotel.Text;
            string HargaFasilitasHotel = textBoxHargaFasilitasHotel.Text;
            
            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                // buka gerbang
                connection.Open();

                // buat Insert Sql Query Statement
                string insert = "UPDATE tfasilitashotel SET idfasilitashotel = @idfasilitashotel, namafasilitashotel = @namafasilitashotel, hargafasilitashotel = @hargafasilitashotel WHERE idfasilitashotel = @idfasilitashotel";

                // Insert Data kedalam Table
                SqlCommand cmd = new SqlCommand(insert, connection);

                // tambahkan Parameter kedalam Cmd
                cmd.Parameters.AddWithValue("@idfasilitashotel", IdFasilitasHotel);
                cmd.Parameters.AddWithValue("@namafasilitashotel", NamaFasilitasHotel);
                cmd.Parameters.AddWithValue("@hargafasilitashotel", HargaFasilitasHotel);

                // execute data
                int insertResult = cmd.ExecuteNonQuery();

                // check Query Command
                if (insertResult == 1)
                {
                    MessageBox.Show("Berhasil");
                }
                else
                {
                    MessageBox.Show("Gagal");
                }

                // tutup gerbang
                connection.Close();

                // refresh
                BindDatabase();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            string IdFasilitasHotel = textBoxIdFasilitasHotel.Text;
            string judul = "Pesan Konfirmasi";
            string pesan = "Anda Yakin Akan Menghapus Id Fasilitas " + IdFasilitasHotel.Trim() + " ?";
            DialogResult result = MessageBox.Show(pesan, judul, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // If Result == Cancel
            if (result != DialogResult.OK)
            {
                // batal menghapus
                return;
            }

            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                // buka gerbang
                connection.Open();

                // buat Insert Sql Query Statement
                string insert = "DELETE FROM tfasilitashotel WHERE idfasilitashotel = @idfasilitashotel";

                // Insert Data kedalam Table
                SqlCommand cmd = new SqlCommand(insert, connection);

                // tambhakan Parameter kedalam Cmd
                cmd.Parameters.AddWithValue("@idfasilitashotel", IdFasilitasHotel);

                // execute Data
                int insertResult = cmd.ExecuteNonQuery();

                // check Query Command
                if (insertResult == 1)
                {
                    MessageBox.Show("Berhasil");
                }
                else
                {
                    MessageBox.Show("Gagal");
                }

                // tutup gerbang
                connection.Close();

                // refresh
                BindDatabase();
            }
        }

    }
}
