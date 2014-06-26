namespace KELOMPOK8
{
    partial class controlFasilitasKamar
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGVFasilitasKamar = new System.Windows.Forms.DataGridView();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFasilitasKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "DATA FASILITAS KAMAR";
            // 
            // dataGVFasilitasKamar
            // 
            this.dataGVFasilitasKamar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGVFasilitasKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVFasilitasKamar.Location = new System.Drawing.Point(14, 39);
            this.dataGVFasilitasKamar.Name = "dataGVFasilitasKamar";
            this.dataGVFasilitasKamar.Size = new System.Drawing.Size(650, 450);
            this.dataGVFasilitasKamar.TabIndex = 10;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(683, 146);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(91, 36);
            this.buttonHapus.TabIndex = 17;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(683, 93);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(91, 36);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonTambah
            // 
            this.buttonTambah.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(683, 39);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(91, 36);
            this.buttonTambah.TabIndex = 15;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            // 
            // controlFasilitasKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVFasilitasKamar);
            this.Name = "controlFasilitasKamar";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVFasilitasKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVFasilitasKamar;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonTambah;
    }
}
