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
        
        public controlKategoriKamar()
        {
            InitializeComponent();
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
    }
}
