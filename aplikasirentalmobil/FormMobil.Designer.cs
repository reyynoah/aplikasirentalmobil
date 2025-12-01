namespace aplikasirentalmobil
{
    partial class FormMobil
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvMobil = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPlat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMerk = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTipe = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTahun = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnHapus = new Guna.UI2.WinForms.Guna2Button();
            this.btnBersihkan = new Guna.UI2.WinForms.Guna2Button();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobil)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMobil
            // 
            this.dgvMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMobil.Location = new System.Drawing.Point(68, 84);
            this.dgvMobil.Name = "dgvMobil";
            this.dgvMobil.Size = new System.Drawing.Size(314, 246);
            this.dgvMobil.TabIndex = 9;
            this.dgvMobil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMobil_CellClick);
            this.dgvMobil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMobil_CellContentClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(226, 11);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(368, 40);
            this.guna2HtmlLabel1.TabIndex = 28;
            this.guna2HtmlLabel1.Text = "FORM TAMBAH MOBIL";
            // 
            // txtPlat
            // 
            this.txtPlat.BorderRadius = 10;
            this.txtPlat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlat.DefaultText = "";
            this.txtPlat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlat.Location = new System.Drawing.Point(440, 84);
            this.txtPlat.Name = "txtPlat";
            this.txtPlat.PlaceholderText = "Nomor Plat";
            this.txtPlat.SelectedText = "";
            this.txtPlat.Size = new System.Drawing.Size(200, 36);
            this.txtPlat.TabIndex = 29;
            // 
            // txtMerk
            // 
            this.txtMerk.BorderRadius = 10;
            this.txtMerk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMerk.DefaultText = "";
            this.txtMerk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMerk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMerk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMerk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMerk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMerk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMerk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMerk.Location = new System.Drawing.Point(440, 126);
            this.txtMerk.Name = "txtMerk";
            this.txtMerk.PlaceholderText = "Merk Mobil";
            this.txtMerk.SelectedText = "";
            this.txtMerk.Size = new System.Drawing.Size(200, 36);
            this.txtMerk.TabIndex = 30;
            // 
            // txtTipe
            // 
            this.txtTipe.BorderRadius = 10;
            this.txtTipe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipe.DefaultText = "";
            this.txtTipe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTipe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTipe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTipe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipe.Location = new System.Drawing.Point(440, 168);
            this.txtTipe.Name = "txtTipe";
            this.txtTipe.PlaceholderText = "Tipe Mobil";
            this.txtTipe.SelectedText = "";
            this.txtTipe.Size = new System.Drawing.Size(200, 36);
            this.txtTipe.TabIndex = 31;
            // 
            // txtTahun
            // 
            this.txtTahun.BorderRadius = 10;
            this.txtTahun.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTahun.DefaultText = "";
            this.txtTahun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTahun.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTahun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTahun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTahun.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTahun.Location = new System.Drawing.Point(440, 210);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.PlaceholderText = "Tahun Rilis";
            this.txtTahun.SelectedText = "";
            this.txtTahun.Size = new System.Drawing.Size(200, 36);
            this.txtTahun.TabIndex = 32;
            // 
            // txtHarga
            // 
            this.txtHarga.BorderRadius = 10;
            this.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHarga.DefaultText = "";
            this.txtHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.Location = new System.Drawing.Point(440, 252);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PlaceholderText = "Harga Sewa";
            this.txtHarga.SelectedText = "";
            this.txtHarga.Size = new System.Drawing.Size(200, 36);
            this.txtHarga.TabIndex = 33;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderRadius = 10;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Location = new System.Drawing.Point(440, 294);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 36);
            this.cmbStatus.TabIndex = 35;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BorderRadius = 15;
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(657, 89);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 31);
            this.btnSimpan.TabIndex = 36;
            this.btnSimpan.Text = "TAMBAH";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 15;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(657, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "EDIT";
            // 
            // btnHapus
            // 
            this.btnHapus.BorderRadius = 15;
            this.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHapus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(657, 163);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 31);
            this.btnHapus.TabIndex = 38;
            this.btnHapus.Text = "HAPUS";
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.BorderRadius = 15;
            this.btnBersihkan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBersihkan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBersihkan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBersihkan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBersihkan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBersihkan.ForeColor = System.Drawing.Color.White;
            this.btnBersihkan.Location = new System.Drawing.Point(657, 227);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(75, 31);
            this.btnBersihkan.TabIndex = 39;
            this.btnBersihkan.Text = "CLEAR";
            // 
            // btnKembali
            // 
            this.btnKembali.BorderRadius = 15;
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(657, 268);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnKembali.Size = new System.Drawing.Size(75, 31);
            this.btnKembali.TabIndex = 40;
            this.btnKembali.Text = "KEMBALI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 60);
            this.panel1.TabIndex = 41;
            // 
            // FormMobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnBersihkan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.txtTipe);
            this.Controls.Add(this.txtMerk);
            this.Controls.Add(this.txtPlat);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgvMobil);
            this.Controls.Add(this.panel1);
            this.Name = "FormMobil";
            this.Text = "FormMobil";
            this.Load += new System.EventHandler(this.FormMobil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMobil;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPlat;
        private Guna.UI2.WinForms.Guna2TextBox txtMerk;
        private Guna.UI2.WinForms.Guna2TextBox txtTipe;
        private Guna.UI2.WinForms.Guna2TextBox txtTahun;
        private Guna.UI2.WinForms.Guna2TextBox txtHarga;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnHapus;
        private Guna.UI2.WinForms.Guna2Button btnBersihkan;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private System.Windows.Forms.Panel panel1;
    }
}
