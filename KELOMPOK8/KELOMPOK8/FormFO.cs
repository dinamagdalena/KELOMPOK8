﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KELOMPOK8
{
    public partial class FormFO : Form
    {
        public FormFO()
        {
            InitializeComponent();
            
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanelBackOffice_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
