namespace aplikasirentalmobil
{
    partial class FormTransaksi
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
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTglKembali = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMobil = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTglRencana = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenda = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnHitung = new Guna.UI2.WinForms.Guna2Button();
            this.btnProses = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(49, 83);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.Size = new System.Drawing.Size(716, 150);
            this.dgvTransaksi.TabIndex = 0;
            this.dgvTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaksi_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mobil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tanggal Kembali";
            // 
            // dtpTglKembali
            // 
            this.dtpTglKembali.Location = new System.Drawing.Point(410, 229);
            this.dtpTglKembali.Name = "dtpTglKembali";
            this.dtpTglKembali.Size = new System.Drawing.Size(191, 20);
            this.dtpTglKembali.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(407, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tanggal pengembalian hari ini";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 60);
            this.panel1.TabIndex = 51;
            // 
            // txtMobil
            // 
            this.txtMobil.BorderRadius = 15;
            this.txtMobil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMobil.DefaultText = "";
            this.txtMobil.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMobil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMobil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobil.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMobil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMobil.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMobil.Location = new System.Drawing.Point(237, 222);
            this.txtMobil.Name = "txtMobil";
            this.txtMobil.PlaceholderText = "";
            this.txtMobil.SelectedText = "";
            this.txtMobil.Size = new System.Drawing.Size(155, 31);
            this.txtMobil.TabIndex = 52;
            // 
            // txtNama
            // 
            this.txtNama.BorderRadius = 15;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.Location = new System.Drawing.Point(237, 186);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderText = "";
            this.txtNama.SelectedText = "";
            this.txtNama.Size = new System.Drawing.Size(155, 30);
            this.txtNama.TabIndex = 53;
            // 
            // txtTglRencana
            // 
            this.txtTglRencana.BorderRadius = 15;
            this.txtTglRencana.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTglRencana.DefaultText = "";
            this.txtTglRencana.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTglRencana.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTglRencana.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTglRencana.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTglRencana.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTglRencana.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTglRencana.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTglRencana.Location = new System.Drawing.Point(237, 259);
            this.txtTglRencana.Name = "txtTglRencana";
            this.txtTglRencana.PlaceholderText = "";
            this.txtTglRencana.SelectedText = "";
            this.txtTglRencana.Size = new System.Drawing.Size(155, 30);
            this.txtTglRencana.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Denda";
            // 
            // txtDenda
            // 
            this.txtDenda.BorderRadius = 15;
            this.txtDenda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDenda.DefaultText = "";
            this.txtDenda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDenda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDenda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDenda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDenda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDenda.Location = new System.Drawing.Point(479, 259);
            this.txtDenda.Name = "txtDenda";
            this.txtDenda.PlaceholderText = "";
            this.txtDenda.SelectedText = "";
            this.txtDenda.Size = new System.Drawing.Size(122, 30);
            this.txtDenda.TabIndex = 55;
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.Color.Transparent;
            this.btnHitung.BorderRadius = 20;
            this.btnHitung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHitung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHitung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHitung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHitung.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHitung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHitung.ForeColor = System.Drawing.Color.White;
            this.btnHitung.Location = new System.Drawing.Point(638, 183);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(128, 33);
            this.btnHitung.TabIndex = 56;
            this.btnHitung.Text = "Hitung Denda";
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click_1);
            // 
            // btnProses
            // 
            this.btnProses.BackColor = System.Drawing.Color.Transparent;
            this.btnProses.BorderRadius = 20;
            this.btnProses.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProses.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProses.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProses.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProses.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnProses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProses.ForeColor = System.Drawing.Color.White;
            this.btnProses.Location = new System.Drawing.Point(638, 222);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(128, 33);
            this.btnProses.TabIndex = 57;
            this.btnProses.Text = "Proses";
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(638, 261);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 33);
            this.btnRefresh.TabIndex = 58;
            this.btnRefresh.Text = "Refresh Tabel";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnKembali
            // 
            this.btnKembali.BorderRadius = 20;
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(330, 405);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(128, 33);
            this.btnKembali.TabIndex = 59;
            this.btnKembali.Text = "Kembali";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.CornflowerBlue;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.HotTrack;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(71, 265);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(694, 134);
            this.guna2GradientPanel1.TabIndex = 60;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtDenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTglRencana);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtMobil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpTglKembali);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvTransaksi);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "FormTransaksi";
            this.Text = "+++++++++";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTglKembali;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMobil;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private Guna.UI2.WinForms.Guna2TextBox txtTglRencana;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtDenda;
        private Guna.UI2.WinForms.Guna2Button btnHitung;
        private Guna.UI2.WinForms.Guna2Button btnProses;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}