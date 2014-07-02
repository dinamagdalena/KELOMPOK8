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
    public partial class FormFO : Form
    {
        private UserControl content;

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
            content = new controlCheckIn();
            flowLayoutPanelBackOffice.Controls.Add(content);   
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            content = new controlCheckOut();
            flowLayoutPanelBackOffice.Controls.Add(content);
        }

        
    }
}
