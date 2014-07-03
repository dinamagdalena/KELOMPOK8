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
    public partial class FormAdmin : Form
    {
        private UserControl content;
        FormLogin log;

        public FormAdmin()
        {
            InitializeComponent();
            
        }

        private void buttonDataLogin_Click(object sender, EventArgs e)
        {
            content = new controlLogin();
            contentLayoutAdmin.Controls.Add(content);
        }

        private void buttonDataKaryawan_Click(object sender, EventArgs e)
        {
                content = new controlKaryawan();
                contentLayoutAdmin.Controls.Add(content);
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            log = new FormLogin();
            this.Close();
            log.Show();
        }

    }
}
