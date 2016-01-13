namespace UniversitePersonelOtomasyon.Formlar.i
{
    partial class frmCocukEkle
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
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblCinsiyeti = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblOkul = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtOkuduguOkul = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbCinsiyeti = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(12, 51);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(22, 13);
            this.lblAdi.TabIndex = 0;
            this.lblAdi.Text = "Adı";
            // 
            // lblCinsiyeti
            // 
            this.lblCinsiyeti.AutoSize = true;
            this.lblCinsiyeti.Location = new System.Drawing.Point(12, 85);
            this.lblCinsiyeti.Name = "lblCinsiyeti";
            this.lblCinsiyeti.Size = new System.Drawing.Size(45, 13);
            this.lblCinsiyeti.TabIndex = 1;
            this.lblCinsiyeti.Text = "Cinsiyeti";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(12, 121);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblOkul
            // 
            this.lblOkul.AutoSize = true;
            this.lblOkul.Location = new System.Drawing.Point(12, 155);
            this.lblOkul.Name = "lblOkul";
            this.lblOkul.Size = new System.Drawing.Size(76, 13);
            this.lblOkul.TabIndex = 3;
            this.lblOkul.Text = "Okuduğu Okul";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(104, 48);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(121, 20);
            this.txtAdi.TabIndex = 4;
            // 
            // txtOkuduguOkul
            // 
            this.txtOkuduguOkul.Location = new System.Drawing.Point(104, 152);
            this.txtOkuduguOkul.Name = "txtOkuduguOkul";
            this.txtOkuduguOkul.Size = new System.Drawing.Size(121, 20);
            this.txtOkuduguOkul.TabIndex = 7;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(150, 199);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbCinsiyeti
            // 
            this.cbCinsiyeti.FormattingEnabled = true;
            this.cbCinsiyeti.Items.AddRange(new object[] {
            "Erkek",
            "Kız"});
            this.cbCinsiyeti.Location = new System.Drawing.Point(104, 82);
            this.cbCinsiyeti.Name = "cbCinsiyeti";
            this.cbCinsiyeti.Size = new System.Drawing.Size(121, 21);
            this.cbCinsiyeti.TabIndex = 9;
            this.cbCinsiyeti.Text = "<Seçiniz>";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(104, 115);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(105, 20);
            this.dtpDogumTarihi.TabIndex = 10;
            // 
            // frmCocukEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.cbCinsiyeti);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtOkuduguOkul);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblOkul);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblCinsiyeti);
            this.Controls.Add(this.lblAdi);
            this.Name = "frmCocukEkle";
            this.Text = "Çocuk Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblCinsiyeti;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblOkul;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtOkuduguOkul;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbCinsiyeti;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
    }
}