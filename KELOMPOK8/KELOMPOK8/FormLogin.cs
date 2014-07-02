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
        private string status;
        Login login;

        FormAdmin fa;
        FormBackOffice fb;
        FormFO ff;
        public FormLogin()
        {
            InitializeComponent();
            login = new Login();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.Trim().Length == 0 || textBoxPassword.Text.Trim().Length == 0)
            {
                string pesan = "Username atau Password Tidak Boleh Kosong !!!";
                string judul = "Perhatian !!!";
                MessageBox.Show(pesan, judul);
                return;
            }
            
            // cek login ke sql
            if (login.ProsesLogin(textBoxUsername.Text, textBoxPassword.Text, status))
            {
                if (status == "Administrator")
                {
                    fa = new FormAdmin();
                    
                    fa.Show();
                }
                else if (status == "BackOffice")
                {
                    fb = new FormBackOffice();
                   
                    fb.Show();
                }
                else if (status == "FrontOffice")
                {
                    ff = new FormFO();
                    ff.Show();
                }
                
            }
            else
            {
                string message = "Username & Password Salah !!";
                string tittle = "Warning";
                MessageBox.Show(message, tittle);
            }
            
        }

        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            status = (sender as RadioButton).Text;
        }

        private void radioButtonBO_CheckedChanged(object sender, EventArgs e)
        {
            status = (sender as RadioButton).Text;
        }

        private void radioButtonFO_CheckedChanged(object sender, EventArgs e)
        {
            status = (sender as RadioButton).Text;
        }

    }
}
