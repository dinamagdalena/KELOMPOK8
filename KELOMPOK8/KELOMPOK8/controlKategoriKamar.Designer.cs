namespace KELOMPOK8
{
    partial class controlKategoriKamar
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
            this.dataGVKategoriKamar = new System.Windows.Forms.DataGridView();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.labelNamaKategori = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNamaKategori = new System.Windows.Forms.TextBox();
            this.textFasilitas = new System.Windows.Forms.TextBox();
            this.textIdFasilitas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKategoriKamar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "DATA KATEGORI KAMAR";
            // 
            // dataGVKategoriKamar
            // 
            this.dataGVKategoriKamar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGVKategoriKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVKategoriKamar.Location = new System.Drawing.Point(16, 103);
            this.dataGVKategoriKamar.Name = "dataGVKategoriKamar";
            this.dataGVKategoriKamar.Size = new System.Drawing.Size(761, 383);
            this.dataGVKategoriKamar.TabIndex = 10;
            this.dataGVKategoriKamar.SelectionChanged += new System.EventHandler(this.dataGVKategoriKamar_SelectionChanged);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapus.Location = new System.Drawing.Point(696, 45);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(81, 51);
            this.buttonHapus.TabIndex = 17;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.Location = new System.Drawing.Point(614, 45);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(76, 51);
            this.buttonUbah.TabIndex = 16;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = true;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.Location = new System.Drawing.Point(530, 45);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(78, 51);
            this.buttonTambah.TabIndex = 15;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // labelNamaKategori
            // 
            this.labelNamaKategori.AutoSize = true;
            this.labelNamaKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaKategori.Location = new System.Drawing.Point(13, 45);
            this.labelNamaKategori.Name = "labelNamaKategori";
            this.labelNamaKategori.Size = new System.Drawing.Size(114, 17);
            this.labelNamaKategori.TabIndex = 18;
            this.labelNamaKategori.Text = "Nama Kategori  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fasilitas            :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Id Fasilitas  :";
            // 
            // textNamaKategori
            // 
            this.textNamaKategori.Location = new System.Drawing.Point(148, 45);
            this.textNamaKategori.Name = "textNamaKategori";
            this.textNamaKategori.Size = new System.Drawing.Size(376, 20);
            this.textNamaKategori.TabIndex = 21;
            // 
            // textFasilitas
            // 
            this.textFasilitas.Location = new System.Drawing.Point(148, 76);
            this.textFasilitas.Name = "textFasilitas";
            this.textFasilitas.Size = new System.Drawing.Size(200, 20);
            this.textFasilitas.TabIndex = 22;
            // 
            // textIdFasilitas
            // 
            this.textIdFasilitas.Location = new System.Drawing.Point(446, 76);
            this.textIdFasilitas.Name = "textIdFasilitas";
            this.textIdFasilitas.Size = new System.Drawing.Size(78, 20);
            this.textIdFasilitas.TabIndex = 23;
            // 
            // controlKategoriKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.textIdFasilitas);
            this.Controls.Add(this.textFasilitas);
            this.Controls.Add(this.textNamaKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNamaKategori);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVKategoriKamar);
            this.Name = "controlKategoriKamar";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.controlKategoriKamar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKategoriKamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGVKategoriKamar;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label labelNamaKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNamaKategori;
        private System.Windows.Forms.TextBox textFasilitas;
        private System.Windows.Forms.TextBox textIdFasilitas;
    }
}
