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
    public partial class controlKategoriKamar : UserControl
    {
        // Create Connection String Variable
        private string strConnection = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;
        
        // Id Database
        private string id;

        public controlKategoriKamar()
        {
            InitializeComponent();
        }

        // Create Method To Clear TextBox in Form
        private void ClearForm()
        {
            textNamaKategori.Clear();
            textFasilitas.Clear();
            textIdFasilitas.Clear();
        }

        // Create Method To Bind Database
        private void BindDatabase()
        {
            // Create Sql Connection
            SqlConnection connection = new SqlConnection(strConnection);

            // Select Data Using Connection
            using (connection)
            {
                // Open The Gate
                connection.Open();

                // Create String Sql Statement
                string select = "SELECT * FROM tfasilitaskamar";

                // Select Data
                SqlCommand cmd = new SqlCommand(select, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                // Load Reader Into Table
                DataTable table = new DataTable();
                table.Load(reader);

                // Bind Table Into Datagridview
                dataGVKategoriKamar.DataSource = table;

                // Clear Selection In Form
                dataGVKategoriKamar.ClearSelection();

                // Clear Form
                ClearForm();

                // Close The Gate
                connection.Close();
            }
        }

        private void controlKategoriKamar_Load(object sender, EventArgs e)
        {
            // Call BindDatabase Method
            BindDatabase();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string Nama_Kategori = textNamaKategori.Text;
            string Fasilitas = textFasilitas.Text;
            string Id_Fasilitas_Kamar = textIdFasilitas.Text;

            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                // Open The Gate
                connection.Open();

                // Create Insert Sql Query Statement
                string insert = "INSERT INTO tfasilitaskamar(nama_kategori, fasilitas, id_fasilitas_kamar) values (@nama_kategori, @fasilitas, @id_fasilitas_kamar)";
                
                // Insert Data Into Table
                SqlCommand cmd = new SqlCommand(insert, connection);

                // Add Parameter Into Cmd
                cmd.Parameters.AddWithValue("@nama_kategori", Nama_Kategori);
                cmd.Parameters.AddWithValue("@fasilitas", Fasilitas);
                cmd.Parameters.AddWithValue("@id_fasilitas_kamar", Id_Fasilitas_Kamar);

                // Execute Data
                int insertResult = cmd.ExecuteNonQuery();

                // Check Query Command
                if (insertResult == 1)
                {
                    MessageBox.Show("Berhasil");
                }
                else
                {
                    MessageBox.Show("Gagal");
                }

                // Close The Gate
                connection.Close();

                // Refresh
                BindDatabase();
            }
        }

        private void dataGVKategoriKamar_SelectionChanged(object sender, EventArgs e)
        {
            // Detect User Selection
            foreach (DataGridViewRow row in dataGVKategoriKamar.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                string Nama_Kategori = row.Cells[1].Value.ToString();
                string Fasilitas = row.Cells[2].Value.ToString();
                string Id_Fasilitas = row.Cells[3].Value.ToString();

                textNamaKategori.Text = Nama_Kategori;
                textFasilitas.Text = Fasilitas;
                textIdFasilitas.Text = Id_Fasilitas;
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            string Nama_Kategori = textNamaKategori.Text;
            string Fasilitas = textFasilitas.Text;
            string Id_Fasilitas_Kamar = textIdFasilitas.Text;

            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                // Open The Gate
                connection.Open();

                // Create Insert Sql Query Statement
                string insert = "UPDATE tkategori SET nama_kategori = @nama_kategori, fasilitas = @fasilitas, id_fasilitas_kamar = @id_fasilitas_kamar WHERE id_kategori = @id";

                // Insert Data Into Table
                SqlCommand cmd = new SqlCommand(insert, connection);

                // Add Parameter Into Cmd
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama_kategori", Nama_Kategori);
                cmd.Parameters.AddWithValue("@fasilitas", Fasilitas);
                cmd.Parameters.AddWithValue("@id_fasilitas_kamar", Id_Fasilitas_Kamar);

                // Execute Data
                int insertResult = cmd.ExecuteNonQuery();

                // Check Query Command
                if (insertResult == 1)
                {
                    MessageBox.Show("Berhasil");
                }
                else
                {
                    MessageBox.Show("Gagal");
                }

                // Close The Gate
                connection.Close();

                // Refresh
                BindDatabase();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            string Nama_Kategori = textNamaKategori.Text;
            string title = "Pesan Konfirmasi";
            string message = "Anda Yakin Akan Menghapus Nama Kategori " + Nama_Kategori.Trim() + " ?";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // If Result == Cancel
            if (result != DialogResult.OK)
            {
                // Cancel Delete
                return;
            }

            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                // Open The Gate
                connection.Open();

                // Create Insert Sql Query Statement
                string insert = "DELETE FROM tkategori WHERE id_kategori = @id";

                // Insert Data Into Table
                SqlCommand cmd = new SqlCommand(insert, connection);

                // Add Parameter Into Cmd
                cmd.Parameters.AddWithValue("@id", id);

                // Execute Data
                int insertResult = cmd.ExecuteNonQuery();

                // Check Query Command
                if (insertResult == 1)
                {
                    MessageBox.Show("Berhasil");
                }
                else
                {
                    MessageBox.Show("Gagal");
                }

                // Close The Gate
                connection.Close();

                // Refresh
                BindDatabase();
            }
        }
    }
}
