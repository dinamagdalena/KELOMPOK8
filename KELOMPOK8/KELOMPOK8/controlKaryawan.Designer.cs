namespace KELOMPOK8
{
    partial class controlKaryawan
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
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVKaryawan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKaryawan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHapus
            // 
            this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(668, 264);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(91, 36);
            this.buttonHapus.TabIndex = 9;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(668, 191);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 36);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(668, 120);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(91, 36);
            this.buttonTambah.TabIndex = 7;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "DATA KARYAWAN";
            // 
            // dataGVKaryawan
            // 
            this.dataGVKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGVKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKaryawan.Location = new System.Drawing.Point(-17, 39);
            this.dataGVKaryawan.Name = "dataGVKaryawan";
            this.dataGVKaryawan.Size = new System.Drawing.Size(666, 346);
            this.dataGVKaryawan.TabIndex = 5;
            // 
            // controlKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVKaryawan);
            this.Name = "controlKaryawan";
            this.Size = new System.Drawing.Size(786, 395);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKaryawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVKaryawan;
    }
}
