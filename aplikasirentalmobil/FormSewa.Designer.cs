namespace aplikasirentalmobil
{
    partial class FormSewa
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
            this.lblNamaMobil = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.dtpTglSewa = new System.Windows.Forms.DateTimePicker();
            this.dtpTglKembali = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBayar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBatal = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNamaMobil
            // 
            this.lblNamaMobil.AutoSize = true;
            this.lblNamaMobil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaMobil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNamaMobil.Location = new System.Drawing.Point(147, 54);
            this.lblNamaMobil.Name = "lblNamaMobil";
            this.lblNamaMobil.Size = new System.Drawing.Size(82, 17);
            this.lblNamaMobil.TabIndex = 1;
            this.lblNamaMobil.Text = "Nama Mobil";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHarga.Location = new System.Drawing.Point(147, 71);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(139, 17);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "harganya nanti disini";
            this.lblHarga.Click += new System.EventHandler(this.lblHarga_Click);
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBayar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalBayar.Location = new System.Drawing.Point(145, 138);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(146, 17);
            this.lblTotalBayar.TabIndex = 3;
            this.lblTotalBayar.Text = "total bayar nanti disini";
            this.lblTotalBayar.Click += new System.EventHandler(this.lblTotalBayar_Click);
            // 
            // dtpTglSewa
            // 
            this.dtpTglSewa.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpTglSewa.Location = new System.Drawing.Point(407, 178);
            this.dtpTglSewa.Name = "dtpTglSewa";
            this.dtpTglSewa.Size = new System.Drawing.Size(124, 20);
            this.dtpTglSewa.TabIndex = 4;
            // 
            // dtpTglKembali
            // 
            this.dtpTglKembali.Location = new System.Drawing.Point(148, 111);
            this.dtpTglKembali.Name = "dtpTglKembali";
            this.dtpTglKembali.Size = new System.Drawing.Size(124, 20);
            this.dtpTglKembali.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tanggal Mulai ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tanggal Selesai";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.label10);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnBatal);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnBayar);
            this.guna2CustomGradientPanel1.Controls.Add(this.label9);
            this.guna2CustomGradientPanel1.Controls.Add(this.label8);
            this.guna2CustomGradientPanel1.Controls.Add(this.label7);
            this.guna2CustomGradientPanel1.Controls.Add(this.label6);
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Controls.Add(this.label3);
            this.guna2CustomGradientPanel1.Controls.Add(this.dtpTglKembali);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblNamaMobil);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblHarga);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTotalBayar);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Blue;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.HotTrack;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Aqua;
            this.guna2CustomGradientPanel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(259, 85);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(295, 326);
            this.guna2CustomGradientPanel1.TabIndex = 10;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(302, 13);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(207, 40);
            this.guna2HtmlLabel1.TabIndex = 43;
            this.guna2HtmlLabel1.Text = "FORM SEWA";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 60);
            this.panel1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Mobil ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(24, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harga Sewa ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(84, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "TOTAL :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(134, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(134, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(134, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = ":";
            // 
            // btnBayar
            // 
            this.btnBayar.BorderRadius = 20;
            this.btnBayar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBayar.FillColor = System.Drawing.Color.Blue;
            this.btnBayar.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnBayar.ForeColor = System.Drawing.Color.White;
            this.btnBayar.Location = new System.Drawing.Point(58, 199);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(180, 35);
            this.btnBayar.TabIndex = 12;
            this.btnBayar.Text = "BAYAR";
            // 
            // btnBatal
            // 
            this.btnBatal.BorderRadius = 10;
            this.btnBatal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBatal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBatal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBatal.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnBatal.ForeColor = System.Drawing.Color.White;
            this.btnBatal.Location = new System.Drawing.Point(108, 239);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(76, 24);
            this.btnBatal.TabIndex = 13;
            this.btnBatal.Text = "BATAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(68, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "PEMBAYARAN";
            // 
            // FormSewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpTglSewa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "FormSewa";
            this.Text = "FormSewa";
            this.Load += new System.EventHandler(this.FormSewa_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNamaMobil;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.DateTimePicker dtpTglSewa;
        private System.Windows.Forms.DateTimePicker dtpTglKembali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnBayar;
        private Guna.UI2.WinForms.Guna2Button btnBatal;
        private System.Windows.Forms.Label label10;
    }
}