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
    public partial class FormLogin : Form
    {
        FormAdmin fa;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            fa = new FormAdmin();
            fa.Show();
        }

    }
}
