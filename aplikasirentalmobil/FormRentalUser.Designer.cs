namespace aplikasirentalmobil
{
    partial class FormRentalUser
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMobil;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvMobil = new System.Windows.Forms.DataGridView();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnSewa = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobil)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMobil
            // 
            this.dgvMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMobil.Location = new System.Drawing.Point(46, 82);
            this.dgvMobil.Name = "dgvMobil";
            this.dgvMobil.Size = new System.Drawing.Size(696, 200);
            this.dgvMobil.TabIndex = 1;
            this.dgvMobil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMobil_CellClick);
            this.dgvMobil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMobil_CellContentClick);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(643, 383);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 25);
            this.btnLogout.TabIndex = 47;
            this.btnLogout.Text = "LOGOUT";
            // 
            // btnSewa
            // 
            this.btnSewa.BorderRadius = 25;
            this.btnSewa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSewa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSewa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSewa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSewa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSewa.ForeColor = System.Drawing.Color.White;
            this.btnSewa.Location = new System.Drawing.Point(301, 302);
            this.btnSewa.Name = "btnSewa";
            this.btnSewa.Size = new System.Drawing.Size(180, 45);
            this.btnSewa.TabIndex = 48;
            this.btnSewa.Text = "Sewa Mobil";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(272, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(254, 40);
            this.guna2HtmlLabel1.TabIndex = 43;
            this.guna2HtmlLabel1.Text = "RENTAL MOBIL";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Location = new System.Drawing.Point(-11, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 60);
            this.panel1.TabIndex = 49;
            // 
            // FormRentalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSewa);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvMobil);
            this.Name = "FormRentalUser";
            this.Text = "FormRentalUser";
            this.Load += new System.EventHandler(this.FormRentalUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobil)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnSewa;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}
