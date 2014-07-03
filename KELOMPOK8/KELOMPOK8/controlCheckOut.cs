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
    public partial class controlCheckOut : UserControl
    {
        Checkout CO = new Checkout();
        public controlCheckOut()
        {
            InitializeComponent();
        }

        private string strConnection = ConfigurationManager.ConnectionStrings["DbHotelConnectionString"].ConnectionString;
        private List<Checkout> output = new List<Checkout>;
        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            //show form 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(strConnection);
            using (connection)
            {
                //Open Gate
                connection.Open();

                //create Query
                string query ="SELECT TTransaksi.NoKTP WHERE NoKmr =";
                SqlCommand cmd = new SqlCommand(query, connection);
            }
        }

       
    }
}
