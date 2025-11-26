namespace aplikasirentalmobil
{
    partial class DashboardAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMobil = new System.Windows.Forms.Button();
            this.btnPelanggan = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ini admin lah";
            // 
            // btnMobil
            // 
            this.btnMobil.Location = new System.Drawing.Point(300, 124);
            this.btnMobil.Name = "btnMobil";
            this.btnMobil.Size = new System.Drawing.Size(120, 23);
            this.btnMobil.TabIndex = 1;
            this.btnMobil.Text = "Kelola Mobil";
            this.btnMobil.UseVisualStyleBackColor = true;
            this.btnMobil.Click += new System.EventHandler(this.btnMobil_Click);
            // 
            // btnPelanggan
            // 
            this.btnPelanggan.Location = new System.Drawing.Point(300, 153);
            this.btnPelanggan.Name = "btnPelanggan";
            this.btnPelanggan.Size = new System.Drawing.Size(120, 23);
            this.btnPelanggan.TabIndex = 2;
            this.btnPelanggan.Text = "Kelola Pelanggan";
            this.btnPelanggan.UseVisualStyleBackColor = true;
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Location = new System.Drawing.Point(300, 182);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(120, 23);
            this.btnTransaksi.TabIndex = 3;
            this.btnTransaksi.Text = "Kelola Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(300, 211);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTransaksi);
            this.Controls.Add(this.btnPelanggan);
            this.Controls.Add(this.btnMobil);
            this.Controls.Add(this.label1);
            this.Name = "DashboardAdmin";
            this.Text = "DashboardAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMobil;
        private System.Windows.Forms.Button btnPelanggan;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnLogout;
    }
}