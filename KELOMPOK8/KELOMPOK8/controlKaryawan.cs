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
    public partial class controlKaryawan : UserControl
    {
        private string JK;

        private string strConn = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;
        private string idKaryawan;
        public controlKaryawan()
        {
            InitializeComponent();
        }

        private void resetForm()
        {
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxTelepon.Text = "";
        }

        private void BindDataBase()
        {
            SqlConnection conn = new SqlConnection(strConn);

            using (conn)
            {
                //open the gate
                conn.Open();
                
                //membuat perintah sql
                string select = "SELECT * FROM tkaryawan";

                //select data
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //load reader into table 
                DataTable table = new DataTable();
                table.Load(reader);

                //bind data table ke data grid view
                dataGVKaryawan.DataSource = table;
                dataGVKaryawan.ClearSelection();

                //reset form
                resetForm();

                //close the gate
                conn.Close();

            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string namakaryawan = textBoxNama.Text;
            string alamatkaryawan = textBoxAlamat.Text;
            string notelpkaryawan = textBoxTelepon.Text;
            string jeniskelaminkaryawan = JK;

            SqlConnection conn = new SqlConnection(strConn);

            using (conn)
            {
                //open the gate
                conn.Open();

                //membuat perintah sql
                string insert = "INSERT INTO tkaryawan (namakaryawan, alamatkaryawan, notelpkaryawan, jeniskelaminkaryawan) values (@NamaKaryawan, @AlamatKaryawan, @NoTelpKaryawan, @JenisKelaminKaryawan)";

                //insert data into table
                SqlCommand cmd = new SqlCommand(insert, conn);

                //add parametes into cmd
                cmd.Parameters.AddWithValue("@NamaKaryawan",namakaryawan);
                cmd.Parameters.AddWithValue("@AlamatKaryawan", alamatkaryawan);
                cmd.Parameters.AddWithValue("@NoTelpKaryawan",notelpkaryawan);
                cmd.Parameters.AddWithValue("@JenisKelaminKaryawan", jeniskelaminkaryawan);

                //execute data
                cmd.ExecuteNonQuery();

                //close teh gate
                conn.Close();

                //refresh
                BindDataBase();

            }

        }

        private void radioButtonLaki_CheckedChanged(object sender, EventArgs e)
        {
            JK = (sender as RadioButton).Text;
        }

        private void radioButtonPerem_CheckedChanged(object sender, EventArgs e)
        {
            JK = (sender as RadioButton).Text;
        }

        private void controlKaryawan_Load(object sender, EventArgs e)
        {
            BindDataBase();
        }

        private void dataGVKaryawan_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGVKaryawan.SelectedRows)
            {
                idKaryawan = row.Cells[0].Value.ToString();
                string nama = row.Cells[1].Value.ToString();
                string alamat = row.Cells[2].Value.ToString();
                string telp = row.Cells[3].Value.ToString();
                string jeniskelamain = row.Cells[4].Value.ToString();

                textBoxNama.Text = nama;
                textBoxAlamat.Text = alamat;
                textBoxTelepon.Text = telp;
                JK = jeniskelamain;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string namakaryawan = textBoxNama.Text;
            string alamatkaryawan = textBoxAlamat.Text;
            string notelpkaryawan = textBoxTelepon.Text;
            string jeniskelaminkaryawan = JK;

            SqlConnection conn = new SqlConnection(strConn);

            using (conn)
            {
                //open the gate
                conn.Open();

                //membuat perintah sql
                string insert = "UPDATE tkaryawan SET namakaryawan = @NamaKaryawan, alamatkaryawan = @AlamatKaryawan , notelpkaryawan = @NoTelpKaryawan , jeniskelaminkaryawan = @JenisKelaminKaryawan WHERE idkaryawan = @idkaryawan";

                //insert data into table
                SqlCommand cmd = new SqlCommand(insert, conn);

                //add parametes into cmd
                cmd.Parameters.AddWithValue("@IdKaryawan", idKaryawan);
                cmd.Parameters.AddWithValue("@NamaKaryawan", namakaryawan);
                cmd.Parameters.AddWithValue("@AlamatKaryawan", alamatkaryawan);
                cmd.Parameters.AddWithValue("@NoTelpKaryawan", notelpkaryawan);
                cmd.Parameters.AddWithValue("@JenisKelaminKaryawan", jeniskelaminkaryawan);

                //execute data
                cmd.ExecuteNonQuery();

                //close teh gate
                conn.Close();

                //refresh
                BindDataBase();
            }
            
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string judul = "Pesan Konfirmasi";
            string pesan = "Apakah Anda Yakin Nama " + nama.Trim() + " Akan Dihapus ??";
            DialogResult result = MessageBox.Show(pesan, judul, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //result = cancel
            if (result != DialogResult.OK)
            {
                //cancel delete
                return;
            }

            SqlConnection conn = new SqlConnection(strConn);
            using(conn)
            {
                //open the gate
                conn.Open();

                //membuat perintah sql
                string insert = "DELETE FROM tkaryawan WHERE idkaryawan = @idkaryawan";

                //insert data into table
                SqlCommand cmd = new SqlCommand(insert, conn);

                //add parametes to cmd
                cmd.Parameters.AddWithValue("@idkaryawan", idKaryawan);

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
