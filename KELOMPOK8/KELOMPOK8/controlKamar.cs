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
    public partial class controlKamar : UserControl
    {

        private string strConn = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;
        private string NoKamar;

        public controlKamar()
        {
            InitializeComponent();
        }

        private void resetForm()
        {
            textBoxHargaKamar.Text = "";
            textBoxJumlahKamar.Text = "";
        }

        private void BindDataBase()
        {
            SqlConnection conn = new SqlConnection(strConn);

            using (conn)
            {
                //open the gate
                conn.Open();

                //membuat perintah sql
                string select = "SELECT * FROM tkamar";

                //select data
                SqlCommand cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                //load reader into table 
                DataTable table = new DataTable();
                table.Load(reader);

                //bind data table ke data grid view
                dataGVKamar.DataSource = table;
                dataGVKamar.ClearSelection();

                //reset form
                resetForm();

                //close the gate
                conn.Close();

            }
        }


        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string HargaKamar = textBoxHargaKamar.Text;
            string JumlahKamar = textBoxJumlahKamar.Text;

            SqlConnection conn = new SqlConnection(strConn);

            using (conn)
            {
                //open the gate
                conn.Open();

                //membuat perintah sql
                string insert = "UPDATE tkamar SET hargakamar = @Harga_Kamar , jumlahkamar = @Jumlah_Kamar WHERE nokamar = @No_Kamar";

                //insert data into table
                SqlCommand cmd = new SqlCommand(insert, conn);

                //add parametes into cmd
                cmd.Parameters.AddWithValue("@No_Kamar", NoKamar);
                //cmd.Parameters.AddWithValue("@Id_Kategori", JenisKamar);
                cmd.Parameters.AddWithValue("@Harga_Kamar", HargaKamar);
                cmd.Parameters.AddWithValue("@Jumlah_Kamar", JumlahKamar);

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
            
            string judul = "Pesan Konfirmasi";
            string pesan = "Apakah Anda Yakin No Kamar " + NoKamar.Trim() + " Akan Dihapus ??";
            DialogResult result = MessageBox.Show(pesan, judul, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            //result = cancel
            if (result != DialogResult.OK)
            {
                //cancel delete
                return;
            }

            SqlConnection conn = new SqlConnection(strConn);
            using (conn)
            {
                //open the gate
                conn.Open();

                //membuat perintah sql
                string insert = "DELETE FROM tkamar WHERE nokamar = @No_Kamar";

                //insert data into table
                SqlCommand cmd = new SqlCommand(insert, conn);

                //add parametes to cmd
                cmd.Parameters.AddWithValue("@No_Kamar", NoKamar);

                //execute data
                cmd.ExecuteNonQuery();

                //close teh gate
                conn.Close();

                //refresh
                BindDataBase();

            }
        }

        private void dataGVKamar_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGVKamar.SelectedRows)
            {
                NoKamar = row.Cells[0].Value.ToString();
                string harga = row.Cells[1].Value.ToString();
                string jumlah = row.Cells[2].Value.ToString();
                
                textBoxHargaKamar.Text = harga;
                textBoxJumlahKamar.Text = jumlah;
                
            }
        }

               
    }
}
