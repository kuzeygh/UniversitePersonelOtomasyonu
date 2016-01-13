namespace UniversitePersonelOtomasyon.Formlar.M
{
    partial class frmPersonelKayitDuzenleme
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIstenCikar = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tabcEkranlar = new System.Windows.Forms.TabControl();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(127, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İsim Soyisim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölüm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Çalışma Yeri";
            // 
            // btnIstenCikar
            // 
            this.btnIstenCikar.Location = new System.Drawing.Point(540, 12);
            this.btnIstenCikar.Name = "btnIstenCikar";
            this.btnIstenCikar.Size = new System.Drawing.Size(75, 23);
            this.btnIstenCikar.TabIndex = 1;
            this.btnIstenCikar.Text = "İşten Çıkış";
            this.btnIstenCikar.UseVisualStyleBackColor = true;
            this.btnIstenCikar.Click += new System.EventHandler(this.btnIstenCikar_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(540, 105);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tabcEkranlar
            // 
            this.tabcEkranlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcEkranlar.Location = new System.Drawing.Point(12, 143);
            this.tabcEkranlar.Multiline = true;
            this.tabcEkranlar.Name = "tabcEkranlar";
            this.tabcEkranlar.SelectedIndex = 0;
            this.tabcEkranlar.Size = new System.Drawing.Size(612, 337);
            this.tabcEkranlar.TabIndex = 4;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(109, 116);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.Location = new System.Drawing.Point(540, 76);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(75, 23);
            this.btnResimEkle.TabIndex = 5;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = true;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPersonelKayitDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 492);
            this.Controls.Add(this.btnResimEkle);
            this.Controls.Add(this.tabcEkranlar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIstenCikar);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPersonelKayitDuzenleme";
            this.Text = "Personel Kayıt/Düzeltme";
            this.Load += new System.EventHandler(this.frmPersonelKayitDuzenleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIstenCikar;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.TabControl tabcEkranlar;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}