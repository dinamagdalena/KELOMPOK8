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
       private string strConn = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;
        public controlFasilitasHotel()
        {
            InitializeComponent();
        }
        private void resetForm()
        {
            textBoxIdFasilitasHotel.Text = "";
            textBoxNamaFasilitasHotel.Text = "";
            textBoxHargaFasilitasHotel.Text = "";
        }
        private void BindDataBase()
        {
            SqlConnection conn = new SqlConnection(strConn);

            using (conn)
            {
                //open the gate
                conn.Open();
                
                //membuat perintah sql
                string select = "SELECT * FROM tfasilitashotel";

                //select data
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //load reader into table 
                DataTable table = new DataTable();
                table.Load(reader);

                //bind data table ke data grid view
                dataGVFasilitasHotel.DataSource = table;
                dataGVFasilitasHotel.ClearSelection();

                //reset form
                resetForm();

                //close the gate
                conn.Close();

            }
        }
       
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string idfasilitashotel = textBoxIdFasilitasHotel.Text;
            string namafasilitashotel = textBoxNamaFasilitasHotel.Text;
            string hargafasilitashotel = textBoxHargaFasilitasHotel.Text;

            SqlConnection conn = new SqlConnection(strConn);
            using (conn)
            {
                // buka gerbang
                conn.Open();

                // buat Insert Sql Query Statement
                string insert = "INSERT INTO tfasilitashotel(idfasilitashotel, namafasilitashotel, hargafasilitashotel) values (@IdFasilitasHotel, @NamaFasilitashotel, @HargaFasilitashotel)";

                // Insert Data kedalam Table
                SqlCommand cmd = new SqlCommand(insert, conn);

                // tambahkan Parameter kedalam Cmd
                cmd.Parameters.AddWithValue("@IdFasilitasHotel", idfasilitashotel);
                cmd.Parameters.AddWithValue("@NamaFasilitasHotel", namafasilitashotel);
                cmd.Parameters.AddWithValue("@HargaFasilitasHotel", hargafasilitashotel);

                // execute data
                cmd.ExecuteNonQuery();

                // tutup gerbang
                conn.Close();

                // refresh
                BindDataBase();
            }
        }
        private void controlFasilitasHotel_Load(object sender, EventArgs e)
        {
            BindDataBase();
        }
        private void dataGVFasilitasHotel_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGVFasilitasHotel.SelectedRows)
            {
                string id = row.Cells[0].Value.ToString();
                string nama = row.Cells[1].Value.ToString();
                string harga = row.Cells[2].Value.ToString();

                textBoxIdFasilitasHotel.Text = id;
                textBoxNamaFasilitasHotel.Text = nama;
                textBoxHargaFasilitasHotel.Text = harga;

            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            string idfasilitashotel = textBoxIdFasilitasHotel.Text;
            string namafasilitashotel = textBoxNamaFasilitasHotel.Text;
            string hargafasilitashotel = textBoxHargaFasilitasHotel.Text;
            
            SqlConnection conn = new SqlConnection(strConn);
            using (conn)
            {
                // buka gerbang
                conn.Open();

                // buat Insert Sql Query Statement
                string insert = "UPDATE tfasilitashotel SET idfasilitashotel = @IdFasilitasHotel, namafasilitashotel = @NamaFasilitasHotel, hargafasilitashotel = @HargaFasilitasHotel WHERE idfasilitashotel = @IdFasilitasHotel";

                // Insert Data kedalam Table
                SqlCommand cmd = new SqlCommand(insert, conn);

                // tambahkan Parameter kedalam Cmd
                cmd.Parameters.AddWithValue("@idfasilitashotel", idfasilitashotel);
                cmd.Parameters.AddWithValue("@namafasilitashotel", namafasilitashotel);
                cmd.Parameters.AddWithValue("@hargafasilitashotel", hargafasilitashotel);

                // execute data
                cmd.ExecuteNonQuery();

                // tutup gerbang
                conn.Close();

                // refresh
                BindDataBase();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            string id = textBoxIdFasilitasHotel.Text;
            string judul = "Pesan Konfirmasi";
            string pesan = "Anda Yakin Akan Menghapus Id Fasilitas " + id.Trim() + " ?";
            DialogResult result = MessageBox.Show(pesan, judul, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // If Result == Cancel
            if (result != DialogResult.OK)
            {
                // batal menghapus
                return;
            }

            SqlConnection conn = new SqlConnection(strConn);
            using (conn)
            {
                // buka gerbang
                conn.Open();

                // buat Insert Sql Query Statement
                string insert = "DELETE FROM tfasilitashotel WHERE idfasilitashotel = @IdFasilitashHotel";

                // Insert Data kedalam Table
                SqlCommand cmd = new SqlCommand(insert, conn);

                // tambhakan Parameter kedalam Cmd
                cmd.Parameters.AddWithValue("@IdFasilitasHotel", id);

                // execute Data
                cmd.ExecuteNonQuery();

               
                // tutup gerbang
                conn.Close();

                // refresh
                BindDataBase();
            }
        }
        

        

    }
}
