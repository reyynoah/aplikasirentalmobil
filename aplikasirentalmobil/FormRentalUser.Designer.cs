namespace aplikasirentalmobil
{
    partial class FormRentalUser
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMobil;
        private System.Windows.Forms.Button btnSewa;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMobil = new System.Windows.Forms.DataGridView();
            this.btnSewa = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tampilkan mobil tersedia";
            // 
            // dgvMobil
            // 
            this.dgvMobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMobil.Location = new System.Drawing.Point(46, 78);
            this.dgvMobil.Name = "dgvMobil";
            this.dgvMobil.Size = new System.Drawing.Size(722, 200);
            this.dgvMobil.TabIndex = 1;
            this.dgvMobil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMobil_CellClick);
            // 
            // btnSewa
            // 
            this.btnSewa.Location = new System.Drawing.Point(217, 331);
            this.btnSewa.Name = "btnSewa";
            this.btnSewa.Size = new System.Drawing.Size(120, 30);
            this.btnSewa.TabIndex = 23;
            this.btnSewa.Text = "Sewa Mobil";
            this.btnSewa.UseVisualStyleBackColor = true;
            this.btnSewa.Click += new System.EventHandler(this.btnSewa_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(444, 331);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 30);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormRentalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSewa);
            this.Controls.Add(this.dgvMobil);
            this.Controls.Add(this.label1);
            this.Name = "FormRentalUser";
            this.Text = "FormRentalUser";
            this.Load += new System.EventHandler(this.FormRentalUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
