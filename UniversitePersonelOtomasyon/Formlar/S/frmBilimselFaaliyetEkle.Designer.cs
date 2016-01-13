namespace UniversitePersonelOtomasyon
{
    partial class frmBilimselFaaliyetEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFaaliyetEkleme = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.dateYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYayinAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYayinTuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFaaliyetEkleme);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPuan);
            this.groupBox1.Controls.Add(this.dateYayinTarihi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYayinAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtYayinTuru);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Faaliyet Ekle";
            // 
            // btnFaaliyetEkleme
            // 
            this.btnFaaliyetEkleme.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.save;
            this.btnFaaliyetEkleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFaaliyetEkleme.Location = new System.Drawing.Point(202, 167);
            this.btnFaaliyetEkleme.Name = "btnFaaliyetEkleme";
            this.btnFaaliyetEkleme.Size = new System.Drawing.Size(71, 51);
            this.btnFaaliyetEkleme.TabIndex = 11;
            this.btnFaaliyetEkleme.UseVisualStyleBackColor = true;
            this.btnFaaliyetEkleme.Click += new System.EventHandler(this.btnFaaliyetEkleme_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puan";
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(94, 141);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(179, 20);
            this.txtPuan.TabIndex = 6;
            // 
            // dateYayinTarihi
            // 
            this.dateYayinTarihi.Location = new System.Drawing.Point(94, 106);
            this.dateYayinTarihi.Name = "dateYayinTarihi";
            this.dateYayinTarihi.Size = new System.Drawing.Size(179, 20);
            this.dateYayinTarihi.TabIndex = 5;
            this.dateYayinTarihi.ValueChanged += new System.EventHandler(this.dateYayinTarihi_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yayın Tarihi";
            // 
            // txtYayinAdi
            // 
            this.txtYayinAdi.Location = new System.Drawing.Point(94, 69);
            this.txtYayinAdi.Name = "txtYayinAdi";
            this.txtYayinAdi.Size = new System.Drawing.Size(179, 20);
            this.txtYayinAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı";
            // 
            // txtYayinTuru
            // 
            this.txtYayinTuru.Location = new System.Drawing.Point(94, 32);
            this.txtYayinTuru.Name = "txtYayinTuru";
            this.txtYayinTuru.Size = new System.Drawing.Size(179, 20);
            this.txtYayinTuru.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yayin Türü";
            // 
            // frmBilimselFaaliyetEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBilimselFaaliyetEkle";
            this.Text = "frmBilimselFaaliyetEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.DateTimePicker dateYayinTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYayinAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYayinTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFaaliyetEkleme;
    }
}