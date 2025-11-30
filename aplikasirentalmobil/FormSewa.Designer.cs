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
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNamaMobil
            // 
            this.lblNamaMobil.AutoSize = true;
            this.lblNamaMobil.Location = new System.Drawing.Point(100, 109);
            this.lblNamaMobil.Name = "lblNamaMobil";
            this.lblNamaMobil.Size = new System.Drawing.Size(149, 13);
            this.lblNamaMobil.TabIndex = 1;
            this.lblNamaMobil.Text = "nama mobil nanti muncul disini";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(100, 140);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(103, 13);
            this.lblHarga.TabIndex = 2;
            this.lblHarga.Text = "harganya nanti disini";
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Location = new System.Drawing.Point(100, 178);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(108, 13);
            this.lblTotalBayar.TabIndex = 3;
            this.lblTotalBayar.Text = "total bayar nanti disini";
            // 
            // dtpTglSewa
            // 
            this.dtpTglSewa.Location = new System.Drawing.Point(371, 132);
            this.dtpTglSewa.Name = "dtpTglSewa";
            this.dtpTglSewa.Size = new System.Drawing.Size(200, 20);
            this.dtpTglSewa.TabIndex = 4;
            // 
            // dtpTglKembali
            // 
            this.dtpTglKembali.Location = new System.Drawing.Point(371, 202);
            this.dtpTglKembali.Name = "dtpTglKembali";
            this.dtpTglKembali.Size = new System.Drawing.Size(200, 20);
            this.dtpTglKembali.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tanggal Mulai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tanggal Selesai";
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(196, 314);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(75, 23);
            this.btnBayar.TabIndex = 8;
            this.btnBayar.Text = "bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(329, 314);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // FormSewa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTglKembali);
            this.Controls.Add(this.dtpTglSewa);
            this.Controls.Add(this.lblTotalBayar);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblNamaMobil);
            this.Name = "FormSewa";
            this.Text = "FormSewa";
            this.Load += new System.EventHandler(this.FormSewa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNamaMobil;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.DateTimePicker dtpTglSewa;
        private System.Windows.Forms.DateTimePicker dtpTglKembali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnBatal;
    }
}