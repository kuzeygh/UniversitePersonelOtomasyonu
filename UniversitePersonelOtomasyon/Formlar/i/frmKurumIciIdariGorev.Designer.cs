namespace UniversitePersonelOtomasyon.Formlar.i
{
    partial class frmKurumIciIdariGorev
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
            this.lblGorevler = new System.Windows.Forms.Label();
            this.lblBaslamaTarihi = new System.Windows.Forms.Label();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtpBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtGorevler = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGorevler
            // 
            this.lblGorevler.AutoSize = true;
            this.lblGorevler.Location = new System.Drawing.Point(12, 22);
            this.lblGorevler.Name = "lblGorevler";
            this.lblGorevler.Size = new System.Drawing.Size(50, 13);
            this.lblGorevler.TabIndex = 0;
            this.lblGorevler.Text = "Görevler:";
            // 
            // lblBaslamaTarihi
            // 
            this.lblBaslamaTarihi.AutoSize = true;
            this.lblBaslamaTarihi.Location = new System.Drawing.Point(12, 53);
            this.lblBaslamaTarihi.Name = "lblBaslamaTarihi";
            this.lblBaslamaTarihi.Size = new System.Drawing.Size(79, 13);
            this.lblBaslamaTarihi.TabIndex = 1;
            this.lblBaslamaTarihi.Text = "Başlama Tarihi:";
            // 
            // lblBitisTarihi
            // 
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(12, 80);
            this.lblBitisTarihi.Name = "lblBitisTarihi";
            this.lblBitisTarihi.Size = new System.Drawing.Size(58, 13);
            this.lblBitisTarihi.TabIndex = 2;
            this.lblBitisTarihi.Text = "Bitiş Tarihi:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(12, 112);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(53, 13);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 81);
            this.textBox1.TabIndex = 5;
            // 
            // dtpBaslamaTarihi
            // 
            this.dtpBaslamaTarihi.Location = new System.Drawing.Point(108, 46);
            this.dtpBaslamaTarihi.Name = "dtpBaslamaTarihi";
            this.dtpBaslamaTarihi.Size = new System.Drawing.Size(105, 20);
            this.dtpBaslamaTarihi.TabIndex = 7;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(108, 72);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(105, 20);
            this.dtpBitisTarihi.TabIndex = 8;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(108, 216);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(83, 33);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(197, 216);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 33);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtGorevler
            // 
            this.txtGorevler.Location = new System.Drawing.Point(110, 19);
            this.txtGorevler.Name = "txtGorevler";
            this.txtGorevler.Size = new System.Drawing.Size(163, 20);
            this.txtGorevler.TabIndex = 12;
            // 
            // frmKurumIciIdariGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtGorevler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslamaTarihi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblBitisTarihi);
            this.Controls.Add(this.lblBaslamaTarihi);
            this.Controls.Add(this.lblGorevler);
            this.Name = "frmKurumIciIdariGorev";
            this.Text = "Kurum İçi İdari Görev";
            this.Load += new System.EventHandler(this.frmKurumIciIdariGorev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGorevler;
        private System.Windows.Forms.Label lblBaslamaTarihi;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dtpBaslamaTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtGorevler;
    }
}