﻿namespace KELOMPOK8
{
    partial class controlKamar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVKamar = new System.Windows.Forms.DataGridView();
            this.textBoxHargaKamar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxJumlahKamar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHapus
            // 
            this.buttonHapus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(669, 107);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(91, 36);
            this.buttonHapus.TabIndex = 14;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(572, 107);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 36);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "DATA KAMAR";
            // 
            // dataGVKamar
            // 
            this.dataGVKamar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGVKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKamar.Location = new System.Drawing.Point(12, 38);
            this.dataGVKamar.Name = "dataGVKamar";
            this.dataGVKamar.Size = new System.Drawing.Size(539, 450);
            this.dataGVKamar.TabIndex = 10;
            this.dataGVKamar.SelectionChanged += new System.EventHandler(this.dataGVKamar_SelectionChanged);
            // 
            // textBoxHargaKamar
            // 
            this.textBoxHargaKamar.Location = new System.Drawing.Point(648, 38);
            this.textBoxHargaKamar.Name = "textBoxHargaKamar";
            this.textBoxHargaKamar.Size = new System.Drawing.Size(131, 20);
            this.textBoxHargaKamar.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Harga Kamar";
            // 
            // textBoxJumlahKamar
            // 
            this.textBoxJumlahKamar.Location = new System.Drawing.Point(648, 64);
            this.textBoxJumlahKamar.Name = "textBoxJumlahKamar";
            this.textBoxJumlahKamar.Size = new System.Drawing.Size(40, 20);
            this.textBoxJumlahKamar.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(569, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Jumlah Kamar";
            // 
            // controlKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.textBoxJumlahKamar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxHargaKamar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVKamar);
            this.Name = "controlKamar";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.controlKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVKamar;
        private System.Windows.Forms.TextBox textBoxHargaKamar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxJumlahKamar;
        private System.Windows.Forms.Label label6;
    }
}
