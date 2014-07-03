using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KELOMPOK8
{
    public partial class FormBackOffice : Form
    {
        private UserControl content;

        public FormBackOffice()
        {
            InitializeComponent();
            
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonDataKamar_Click(object sender, EventArgs e)
        {
            content = new controlKamar();
            contentLayoutBackOffice.Controls.Add(content);
        }

        private void buttonDataFasilitasKamar_Click(object sender, EventArgs e)
        {
            content = new controlFasilitasKamar();
            contentLayoutPanelBackOffice.Controls.Add(content);   
        }

        private void buttonDataKategoriKamar_Click(object sender, EventArgs e)
        {
            content = new controlKategoriKamar();
            contentLayoutPanelBackOffice.Controls.Add(content);
        }

        private void buttonDataFasilitasHotel_Click(object sender, EventArgs e)
        {
            content = new controlFasilitasHotel();
            contentLayoutBackOffice.Controls.Add(content);
        }
    }
}
