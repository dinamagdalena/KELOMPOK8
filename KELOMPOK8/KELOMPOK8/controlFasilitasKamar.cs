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
    public partial class controlFasilitasKamar : UserControl
    {
        // Create Connection String Variable
        private string strConnection = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;

        // Id Database
        private string id;

        public controlFasilitasKamar()
        {
            InitializeComponent();
        }

        // Create Method To Clear TextBox in Form
        private void ClearForm()
        {
            textBoxFasillitas.Clear();
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
                dataGVFasilitasKamar.DataSource = table;

                // Clear Selection In Form
                dataGVFasilitasKamar.ClearSelection();

                // Clear Form
                ClearForm();

                // Close The Gate
                connection.Close();
            }
        }

        private void controlFasilitasKamar_Load(object sender, EventArgs e)
        {
            BindDatabase();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string Fasilitas = textBoxFasillitas.Text;
            
            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                // Open The Gate
                connection.Open();

                // Create Insert Sql Query Statement
                string insert = "INSERT INTO tfasilitaskamar(fasilitas) values (@fasilitas)";

                // Insert Data Into Table
                SqlCommand cmd = new SqlCommand(insert, connection);

                // Add Parameter Into Cmd
                
                cmd.Parameters.AddWithValue("@fasilitas", Fasilitas);
                

                // Execute Data
                cmd.ExecuteNonQuery();

            
                // Close The Gate
                connection.Close();

                // Refresh
                BindDatabase();
            }
        }

        private void dataGVFasilitasKamar_SelectionChanged(object sender, EventArgs e)
        {
            // Detect User Selection
            foreach (DataGridViewRow row in dataGVFasilitasKamar.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                string Fasilitas = row.Cells[1].Value.ToString();
                
                
                textBoxFasillitas.Text = Fasilitas;
                
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string Fasilitas = textBoxFasillitas.Text;

            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                // Open The Gate
                connection.Open();

                // Create Insert Sql Query Statement
                string update = "UPDATE tfasilitaskamar SET fasilitas = @fasilitas WHERE id_kategori = @id";

                // Insert Data Into Table
                SqlCommand cmd = new SqlCommand(update, connection);

                // Add Parameter Into Cmd
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fasilitas", Fasilitas);

                // Execute Data
                cmd.ExecuteNonQuery();

                
                // Close The Gate
                connection.Close();

                // Refresh
                BindDatabase();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            string Fasilitas = textBoxFasillitas.Text;
            string title = "Pesan Konfirmasi";
            string message = "Anda Yakin Akan Menghapus Fasilitas " + Fasilitas.Trim() + " ?";
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
                string delete = "DELETE FROM tfasilitaskamar WHERE id_kategori = @id";

                // Insert Data Into Table
                SqlCommand cmd = new SqlCommand(delete, connection);

                // Add Parameter Into Cmd
                cmd.Parameters.AddWithValue("@id", id);

                // Execute Data
                cmd.ExecuteNonQuery();

                // Close The Gate
                connection.Close();

                // Refresh
                BindDatabase();
            }
        }


  
    }
}
