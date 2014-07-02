namespace KELOMPOK8
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonDataKaryawan = new System.Windows.Forms.Button();
            this.buttonDataLogin = new System.Windows.Forms.Button();
            this.labelSelamatDatang = new System.Windows.Forms.Label();
            this.contentLayoutAdmin = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.34805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.65195F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.contentLayoutAdmin, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.buttonDataKaryawan);
            this.panel2.Controls.Add(this.buttonDataLogin);
            this.panel2.Controls.Add(this.labelSelamatDatang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 508);
            this.panel2.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(34, 248);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(118, 41);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click_1);
            // 
            // buttonDataKaryawan
            // 
            this.buttonDataKaryawan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDataKaryawan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataKaryawan.Location = new System.Drawing.Point(34, 178);
            this.buttonDataKaryawan.Name = "buttonDataKaryawan";
            this.buttonDataKaryawan.Size = new System.Drawing.Size(118, 41);
            this.buttonDataKaryawan.TabIndex = 2;
            this.buttonDataKaryawan.Text = "Data Karyawan";
            this.buttonDataKaryawan.UseVisualStyleBackColor = true;
            this.buttonDataKaryawan.Click += new System.EventHandler(this.buttonDataKaryawan_Click);
            // 
            // buttonDataLogin
            // 
            this.buttonDataLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDataLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataLogin.Location = new System.Drawing.Point(34, 110);
            this.buttonDataLogin.Name = "buttonDataLogin";
            this.buttonDataLogin.Size = new System.Drawing.Size(118, 41);
            this.buttonDataLogin.TabIndex = 1;
            this.buttonDataLogin.Text = "Data Login";
            this.buttonDataLogin.UseVisualStyleBackColor = true;
            this.buttonDataLogin.Click += new System.EventHandler(this.buttonDataLogin_Click);
            // 
            // labelSelamatDatang
            // 
            this.labelSelamatDatang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSelamatDatang.AutoSize = true;
            this.labelSelamatDatang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelamatDatang.Location = new System.Drawing.Point(39, 41);
            this.labelSelamatDatang.Name = "labelSelamatDatang";
            this.labelSelamatDatang.Size = new System.Drawing.Size(113, 17);
            this.labelSelamatDatang.TabIndex = 0;
            this.labelSelamatDatang.Text = "Selamat Datang,";
            // 
            // contentLayoutAdmin
            // 
            this.contentLayoutAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contentLayoutAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayoutAdmin.Location = new System.Drawing.Point(197, 3);
            this.contentLayoutAdmin.Name = "contentLayoutAdmin";
            this.contentLayoutAdmin.Size = new System.Drawing.Size(807, 508);
            this.contentLayoutAdmin.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "No Telp. 022- 7312456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jalan Solokan Jeruk No 321";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KELOMPOK8.Properties.Resources.Background3;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonDataKaryawan;
        private System.Windows.Forms.Button buttonDataLogin;
        private System.Windows.Forms.Label labelSelamatDatang;
        private System.Windows.Forms.FlowLayoutPanel contentLayoutAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}