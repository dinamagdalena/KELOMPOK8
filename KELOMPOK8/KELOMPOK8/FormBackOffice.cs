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
        public FormBackOffice()
        {
            InitializeComponent();
            
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
