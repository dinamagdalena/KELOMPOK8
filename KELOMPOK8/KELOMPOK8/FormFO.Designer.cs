namespace KELOMPOK8
{
    partial class FormFO
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
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.labelSelamatDatang = new System.Windows.Forms.Label();
            this.flowLayoutPanelBackOffice = new System.Windows.Forms.FlowLayoutPanel();
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
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelBackOffice, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 514);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.buttonCheckOut);
            this.panel2.Controls.Add(this.buttonCheckIn);
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
            this.buttonLogout.Location = new System.Drawing.Point(33, 251);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(118, 41);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.Location = new System.Drawing.Point(33, 178);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(118, 46);
            this.buttonCheckOut.TabIndex = 2;
            this.buttonCheckOut.Text = "Check Out";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.Location = new System.Drawing.Point(33, 110);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(118, 41);
            this.buttonCheckIn.TabIndex = 1;
            this.buttonCheckIn.Text = "Check In";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
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
            // flowLayoutPanelBackOffice
            // 
            this.flowLayoutPanelBackOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.flowLayoutPanelBackOffice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBackOffice.Location = new System.Drawing.Point(197, 3);
            this.flowLayoutPanelBackOffice.Name = "flowLayoutPanelBackOffice";
            this.flowLayoutPanelBackOffice.Size = new System.Drawing.Size(807, 508);
            this.flowLayoutPanelBackOffice.TabIndex = 2;
            // 
            // FormFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KELOMPOK8.Properties.Resources.Background3;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1500, 900);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "FormFO";
            this.Text = "FormFO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Label labelSelamatDatang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBackOffice;
    }
}