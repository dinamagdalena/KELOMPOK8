﻿namespace KELOMPOK8
{
    partial class FormBackOffice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackOffice));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDataFasilitasHotel = new System.Windows.Forms.Button();
            this.buttonDataFasilitasKamar = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonDataKategoriKamar = new System.Windows.Forms.Button();
            this.buttonDataKamar = new System.Windows.Forms.Button();
            this.labelSelamatDatang = new System.Windows.Forms.Label();
            this.contentLayoutBackOffice = new System.Windows.Forms.FlowLayoutPanel();
            this.contentLayoutPanelBackOffice = new System.Windows.Forms.FlowLayoutPanel();

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
            this.tableLayoutPanel1.Controls.Add(this.contentLayoutBackOffice, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.contentLayoutPanelBackOffice, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 171);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 514);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.buttonDataFasilitasHotel);
            this.panel2.Controls.Add(this.buttonDataFasilitasKamar);
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.buttonDataKategoriKamar);
            this.panel2.Controls.Add(this.buttonDataKamar);
            this.panel2.Controls.Add(this.labelSelamatDatang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 488);
            this.panel2.TabIndex = 1;
            // 
            // buttonDataFasilitasHotel
            // 
            this.buttonDataFasilitasHotel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDataFasilitasHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataFasilitasHotel.Location = new System.Drawing.Point(33, 323);
            this.buttonDataFasilitasHotel.Name = "buttonDataFasilitasHotel";
            this.buttonDataFasilitasHotel.Size = new System.Drawing.Size(118, 46);
            this.buttonDataFasilitasHotel.TabIndex = 3;
            this.buttonDataFasilitasHotel.Text = "Data Fasilitas Hotel";
            this.buttonDataFasilitasHotel.UseVisualStyleBackColor = true;
            this.buttonDataFasilitasHotel.Click += new System.EventHandler(this.buttonDataFasilitasHotel_Click);
            // 
            // buttonDataFasilitasKamar
            // 
            this.buttonDataFasilitasKamar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDataFasilitasKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataFasilitasKamar.Location = new System.Drawing.Point(33, 251);
            this.buttonDataFasilitasKamar.Name = "buttonDataFasilitasKamar";
            this.buttonDataFasilitasKamar.Size = new System.Drawing.Size(118, 46);
            this.buttonDataFasilitasKamar.TabIndex = 3;
            this.buttonDataFasilitasKamar.Text = "Data Fasilitas Kamar";
            this.buttonDataFasilitasKamar.UseVisualStyleBackColor = true;
            this.buttonDataFasilitasKamar.Click += new System.EventHandler(this.buttonDataFasilitasKamar_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(33, 394);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(118, 41);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click_1);
            // 
            // buttonDataKategoriKamar
            // 
            this.buttonDataKategoriKamar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDataKategoriKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataKategoriKamar.Location = new System.Drawing.Point(33, 178);
            this.buttonDataKategoriKamar.Name = "buttonDataKategoriKamar";
            this.buttonDataKategoriKamar.Size = new System.Drawing.Size(118, 46);
            this.buttonDataKategoriKamar.TabIndex = 2;
            this.buttonDataKategoriKamar.Text = "Data Kategori Kamar";
            this.buttonDataKategoriKamar.UseVisualStyleBackColor = true;
            this.buttonDataKategoriKamar.Click += new System.EventHandler(this.buttonDataKategoriKamar_Click);
            // 
            // buttonDataKamar
            // 
            this.buttonDataKamar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDataKamar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDataKamar.Location = new System.Drawing.Point(33, 110);
            this.buttonDataKamar.Name = "buttonDataKamar";
            this.buttonDataKamar.Size = new System.Drawing.Size(118, 41);
            this.buttonDataKamar.TabIndex = 1;
            this.buttonDataKamar.Text = "Data Kamar";
            this.buttonDataKamar.UseVisualStyleBackColor = true;
            this.buttonDataKamar.Click += new System.EventHandler(this.buttonDataKamar_Click);
            // 
            // labelSelamatDatang
            // 
            this.labelSelamatDatang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSelamatDatang.AutoSize = true;
            this.labelSelamatDatang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelamatDatang.Location = new System.Drawing.Point(38, 41);
            this.labelSelamatDatang.Name = "labelSelamatDatang";
            this.labelSelamatDatang.Size = new System.Drawing.Size(113, 17);
            this.labelSelamatDatang.TabIndex = 0;
            this.labelSelamatDatang.Text = "Selamat Datang,";
            // 
            // contentLayoutBackOffice
            // 
            this.contentLayoutBackOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contentLayoutBackOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayoutBackOffice.Location = new System.Drawing.Point(3, 497);
            this.contentLayoutBackOffice.Name = "contentLayoutBackOffice";

            this.contentLayoutBackOffice.Size = new System.Drawing.Size(807, 488);

            this.contentLayoutBackOffice.Size = new System.Drawing.Size(188, 14);

            this.contentLayoutBackOffice.Size = new System.Drawing.Size(807, 488);

            this.contentLayoutBackOffice.TabIndex = 2;
            // 
            // contentLayoutPanelBackOffice
            // 
            this.contentLayoutPanelBackOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contentLayoutPanelBackOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayoutPanelBackOffice.Location = new System.Drawing.Point(3, 497);
            this.contentLayoutPanelBackOffice.Name = "contentLayoutPanelBackOffice";

            this.contentLayoutPanelBackOffice.Size = new System.Drawing.Size(807, 488);
            this.contentLayoutPanelBackOffice.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "No Telp. 022- 7312456";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Jalan Jeruk Mandarin No 321";


            this.contentLayoutPanelBackOffice.Size = new System.Drawing.Size(188, 14);
            this.contentLayoutPanelBackOffice.TabIndex = 2;
            // 
            // FormBackOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KELOMPOK8.Properties.Resources.Background3;
            this.ClientSize = new System.Drawing.Size(1008, 688);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormBackOffice";
            this.Text = "FormBackOffice";
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
        private System.Windows.Forms.Button buttonDataKategoriKamar;
        private System.Windows.Forms.Button buttonDataKamar;
        private System.Windows.Forms.Label labelSelamatDatang;

        private System.Windows.Forms.FlowLayoutPanel contentLayoutBackOffice;

        private System.Windows.Forms.FlowLayoutPanel contentLayoutPanelBackOffice;

        private System.Windows.Forms.Button buttonDataFasilitasHotel;
        private System.Windows.Forms.Button buttonDataFasilitasKamar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

    }
}