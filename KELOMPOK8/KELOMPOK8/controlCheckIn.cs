using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KELOMPOK8
{
    public partial class controlCheckIn : UserControl
    {
        public controlCheckIn()
        {
            InitializeComponent();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            string noktp = textBoxNoKtp.Text;
            string nama = textBoxNamaIn.Text;
            string notelp = textBoxNoTelp.Text;

        }

    }
}
