namespace UniversitePersonelOtomasyon.Formlar.i
{
    partial class frmNufusBilgileri
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
            this.grpKimlikBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbMedeniHali = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtUyrugu = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtAnaAdi = new System.Windows.Forms.TextBox();
            this.txtBabaAdi = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtNufusCuzdanNo = new System.Windows.Forms.TextBox();
            this.lblUyrugu = new System.Windows.Forms.Label();
            this.lblMedeniHali = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblAnaAdi = new System.Windows.Forms.Label();
            this.lblBabaAdi = new System.Windows.Forms.Label();
            this.lblTCKimlikNo = new System.Windows.Forms.Label();
            this.lblNufusCuzdanNo = new System.Windows.Forms.Label();
            this.grpNufusaKayitliOldugu = new System.Windows.Forms.GroupBox();
            this.cmbIlce = new System.Windows.Forms.ComboBox();
            this.cmbVerilisNedeni = new System.Windows.Forms.ComboBox();
            this.cmbIl = new System.Windows.Forms.ComboBox();
            this.txtVerildigiYer = new System.Windows.Forms.TextBox();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.txtAileSiraNo = new System.Windows.Forms.TextBox();
            this.txtCiltNo = new System.Windows.Forms.TextBox();
            this.txtMahKoy = new System.Windows.Forms.TextBox();
            this.lblVerilisNedeni = new System.Windows.Forms.Label();
            this.lblVerildigiYer = new System.Windows.Forms.Label();
            this.lblSiraNo = new System.Windows.Forms.Label();
            this.lblAileSiraNo = new System.Windows.Forms.Label();
            this.lblCiltNo = new System.Windows.Forms.Label();
            this.lblMahKoy = new System.Windows.Forms.Label();
            this.lblIlce = new System.Windows.Forms.Label();
            this.lblIl = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grpKimlikBilgileri.SuspendLayout();
            this.grpNufusaKayitliOldugu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKimlikBilgileri
            // 
            this.grpKimlikBilgileri.Controls.Add(this.cmbMedeniHali);
            this.grpKimlikBilgileri.Controls.Add(this.dtpDogumTarihi);
            this.grpKimlikBilgileri.Controls.Add(this.txtUyrugu);
            this.grpKimlikBilgileri.Controls.Add(this.txtDogumYeri);
            this.grpKimlikBilgileri.Controls.Add(this.txtAnaAdi);
            this.grpKimlikBilgileri.Controls.Add(this.txtBabaAdi);
            this.grpKimlikBilgileri.Controls.Add(this.txtTCKimlikNo);
            this.grpKimlikBilgileri.Controls.Add(this.txtNufusCuzdanNo);
            this.grpKimlikBilgileri.Controls.Add(this.lblUyrugu);
            this.grpKimlikBilgileri.Controls.Add(this.lblMedeniHali);
            this.grpKimlikBilgileri.Controls.Add(this.lblDogumTarihi);
            this.grpKimlikBilgileri.Controls.Add(this.lblDogumYeri);
            this.grpKimlikBilgileri.Controls.Add(this.lblAnaAdi);
            this.grpKimlikBilgileri.Controls.Add(this.lblBabaAdi);
            this.grpKimlikBilgileri.Controls.Add(this.lblTCKimlikNo);
            this.grpKimlikBilgileri.Controls.Add(this.lblNufusCuzdanNo);
            this.grpKimlikBilgileri.Location = new System.Drawing.Point(44, 22);
            this.grpKimlikBilgileri.Name = "grpKimlikBilgileri";
            this.grpKimlikBilgileri.Size = new System.Drawing.Size(617, 144);
            this.grpKimlikBilgileri.TabIndex = 0;
            this.grpKimlikBilgileri.TabStop = false;
            this.grpKimlikBilgileri.Text = "Kimlik Bilgileri";
            // 
            // cmbMedeniHali
            // 
            this.cmbMedeniHali.FormattingEnabled = true;
            this.cmbMedeniHali.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cmbMedeniHali.Location = new System.Drawing.Point(431, 83);
            this.cmbMedeniHali.Name = "cmbMedeniHali";
            this.cmbMedeniHali.Size = new System.Drawing.Size(180, 21);
            this.cmbMedeniHali.TabIndex = 15;
            this.cmbMedeniHali.Text = "<Seçiniz>";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(431, 57);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(106, 20);
            this.dtpDogumTarihi.TabIndex = 14;
            this.dtpDogumTarihi.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // txtUyrugu
            // 
            this.txtUyrugu.Location = new System.Drawing.Point(431, 109);
            this.txtUyrugu.Name = "txtUyrugu";
            this.txtUyrugu.Size = new System.Drawing.Size(180, 20);
            this.txtUyrugu.TabIndex = 13;
            this.txtUyrugu.Text = "TC";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(431, 31);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(180, 20);
            this.txtDogumYeri.TabIndex = 12;
            // 
            // txtAnaAdi
            // 
            this.txtAnaAdi.Location = new System.Drawing.Point(107, 109);
            this.txtAnaAdi.Name = "txtAnaAdi";
            this.txtAnaAdi.Size = new System.Drawing.Size(173, 20);
            this.txtAnaAdi.TabIndex = 11;
            // 
            // txtBabaAdi
            // 
            this.txtBabaAdi.Location = new System.Drawing.Point(107, 85);
            this.txtBabaAdi.Name = "txtBabaAdi";
            this.txtBabaAdi.Size = new System.Drawing.Size(173, 20);
            this.txtBabaAdi.TabIndex = 10;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(107, 57);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(173, 20);
            this.txtTCKimlikNo.TabIndex = 9;
            // 
            // txtNufusCuzdanNo
            // 
            this.txtNufusCuzdanNo.Location = new System.Drawing.Point(107, 31);
            this.txtNufusCuzdanNo.Name = "txtNufusCuzdanNo";
            this.txtNufusCuzdanNo.Size = new System.Drawing.Size(173, 20);
            this.txtNufusCuzdanNo.TabIndex = 8;
            // 
            // lblUyrugu
            // 
            this.lblUyrugu.AutoSize = true;
            this.lblUyrugu.Location = new System.Drawing.Point(325, 112);
            this.lblUyrugu.Name = "lblUyrugu";
            this.lblUyrugu.Size = new System.Drawing.Size(41, 13);
            this.lblUyrugu.TabIndex = 7;
            this.lblUyrugu.Text = "Uyruğu";
            // 
            // lblMedeniHali
            // 
            this.lblMedeniHali.AutoSize = true;
            this.lblMedeniHali.Location = new System.Drawing.Point(325, 88);
            this.lblMedeniHali.Name = "lblMedeniHali";
            this.lblMedeniHali.Size = new System.Drawing.Size(63, 13);
            this.lblMedeniHali.TabIndex = 6;
            this.lblMedeniHali.Text = "Medeni Hali";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(325, 60);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblDogumTarihi.TabIndex = 5;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Location = new System.Drawing.Point(325, 34);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(62, 13);
            this.lblDogumYeri.TabIndex = 4;
            this.lblDogumYeri.Text = "Doğum Yeri";
            // 
            // lblAnaAdi
            // 
            this.lblAnaAdi.AutoSize = true;
            this.lblAnaAdi.Location = new System.Drawing.Point(11, 112);
            this.lblAnaAdi.Name = "lblAnaAdi";
            this.lblAnaAdi.Size = new System.Drawing.Size(44, 13);
            this.lblAnaAdi.TabIndex = 3;
            this.lblAnaAdi.Text = "Ana Adı";
            // 
            // lblBabaAdi
            // 
            this.lblBabaAdi.AutoSize = true;
            this.lblBabaAdi.Location = new System.Drawing.Point(11, 88);
            this.lblBabaAdi.Name = "lblBabaAdi";
            this.lblBabaAdi.Size = new System.Drawing.Size(50, 13);
            this.lblBabaAdi.TabIndex = 2;
            this.lblBabaAdi.Text = "Baba Adı";
            // 
            // lblTCKimlikNo
            // 
            this.lblTCKimlikNo.AutoSize = true;
            this.lblTCKimlikNo.Location = new System.Drawing.Point(11, 60);
            this.lblTCKimlikNo.Name = "lblTCKimlikNo";
            this.lblTCKimlikNo.Size = new System.Drawing.Size(74, 13);
            this.lblTCKimlikNo.TabIndex = 1;
            this.lblTCKimlikNo.Text = "T.C. Kimlik No";
            // 
            // lblNufusCuzdanNo
            // 
            this.lblNufusCuzdanNo.AutoSize = true;
            this.lblNufusCuzdanNo.Location = new System.Drawing.Point(11, 34);
            this.lblNufusCuzdanNo.Name = "lblNufusCuzdanNo";
            this.lblNufusCuzdanNo.Size = new System.Drawing.Size(91, 13);
            this.lblNufusCuzdanNo.TabIndex = 0;
            this.lblNufusCuzdanNo.Text = "Nüfus Cüzdan No";
            // 
            // grpNufusaKayitliOldugu
            // 
            this.grpNufusaKayitliOldugu.Controls.Add(this.cmbIlce);
            this.grpNufusaKayitliOldugu.Controls.Add(this.cmbVerilisNedeni);
            this.grpNufusaKayitliOldugu.Controls.Add(this.cmbIl);
            this.grpNufusaKayitliOldugu.Controls.Add(this.txtVerildigiYer);
            this.grpNufusaKayitliOldugu.Controls.Add(this.txtSiraNo);
            this.grpNufusaKayitliOldugu.Controls.Add(this.txtAileSiraNo);
            this.grpNufusaKayitliOldugu.Controls.Add(this.txtCiltNo);
            this.grpNufusaKayitliOldugu.Controls.Add(this.txtMahKoy);
            this.grpNufusaKayitliOldugu.Controls.Add(this.lblVerilisNedeni);
            this.grpNufusaKayitliOldugu.Controls.Add(this.lblVerildigiYer);
            this.grpNufusaKayitliOldugu.Controls.Add(this.lblSiraNo);
            this.grpNufusaKayitliOldugu.Controls.Add(this.lblAileSiraNo);
            this.grpNufusaKayitliOldugu.Controls.Add(this.lblCiltNo);
            this.grpNufusaKayitliOldugu.Controls.Add(this.lblMahKoy);
            this.grpNufusaKayitliOldugu.Controls.Add(this.lblIlce);
            this.grpNufusaKayitliOldugu.Controls.Add(this.lblIl);
            this.grpNufusaKayitliOldugu.Location = new System.Drawing.Point(44, 172);
            this.grpNufusaKayitliOldugu.Name = "grpNufusaKayitliOldugu";
            this.grpNufusaKayitliOldugu.Size = new System.Drawing.Size(617, 186);
            this.grpNufusaKayitliOldugu.TabIndex = 1;
            this.grpNufusaKayitliOldugu.TabStop = false;
            this.grpNufusaKayitliOldugu.Text = "Nüfusa Kayıtlı Olduğu";
            // 
            // cmbIlce
            // 
            this.cmbIlce.FormattingEnabled = true;
            this.cmbIlce.Location = new System.Drawing.Point(107, 55);
            this.cmbIlce.Name = "cmbIlce";
            this.cmbIlce.Size = new System.Drawing.Size(173, 21);
            this.cmbIlce.TabIndex = 18;
            this.cmbIlce.Text = "<Seçiniz>";
            // 
            // cmbVerilisNedeni
            // 
            this.cmbVerilisNedeni.FormattingEnabled = true;
            this.cmbVerilisNedeni.Items.AddRange(new object[] {
            "Doğum",
            "Yeniden Kayıt",
            "Yenileme veya Değiştirme",
            "Kayıp"});
            this.cmbVerilisNedeni.Location = new System.Drawing.Point(432, 55);
            this.cmbVerilisNedeni.Name = "cmbVerilisNedeni";
            this.cmbVerilisNedeni.Size = new System.Drawing.Size(179, 21);
            this.cmbVerilisNedeni.TabIndex = 17;
            this.cmbVerilisNedeni.Text = "<Seçiniz>";
            // 
            // cmbIl
            // 
            this.cmbIl.FormattingEnabled = true;
            this.cmbIl.Location = new System.Drawing.Point(107, 27);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Size = new System.Drawing.Size(173, 21);
            this.cmbIl.TabIndex = 16;
            this.cmbIl.Text = "<Seçiniz>";
            this.cmbIl.SelectedIndexChanged += new System.EventHandler(this.cmbIl_SelectedIndexChanged);
            // 
            // txtVerildigiYer
            // 
            this.txtVerildigiYer.Location = new System.Drawing.Point(431, 30);
            this.txtVerildigiYer.Name = "txtVerildigiYer";
            this.txtVerildigiYer.Size = new System.Drawing.Size(180, 20);
            this.txtVerildigiYer.TabIndex = 14;
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(107, 160);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(71, 20);
            this.txtSiraNo.TabIndex = 13;
            // 
            // txtAileSiraNo
            // 
            this.txtAileSiraNo.Location = new System.Drawing.Point(107, 134);
            this.txtAileSiraNo.Name = "txtAileSiraNo";
            this.txtAileSiraNo.Size = new System.Drawing.Size(71, 20);
            this.txtAileSiraNo.TabIndex = 12;
            // 
            // txtCiltNo
            // 
            this.txtCiltNo.Location = new System.Drawing.Point(107, 108);
            this.txtCiltNo.Name = "txtCiltNo";
            this.txtCiltNo.Size = new System.Drawing.Size(71, 20);
            this.txtCiltNo.TabIndex = 11;
            // 
            // txtMahKoy
            // 
            this.txtMahKoy.Location = new System.Drawing.Point(107, 85);
            this.txtMahKoy.Name = "txtMahKoy";
            this.txtMahKoy.Size = new System.Drawing.Size(173, 20);
            this.txtMahKoy.TabIndex = 10;
            // 
            // lblVerilisNedeni
            // 
            this.lblVerilisNedeni.AutoSize = true;
            this.lblVerilisNedeni.Location = new System.Drawing.Point(325, 55);
            this.lblVerilisNedeni.Name = "lblVerilisNedeni";
            this.lblVerilisNedeni.Size = new System.Drawing.Size(71, 13);
            this.lblVerilisNedeni.TabIndex = 7;
            this.lblVerilisNedeni.Text = "Veriliş Nedeni";
            // 
            // lblVerildigiYer
            // 
            this.lblVerildigiYer.AutoSize = true;
            this.lblVerildigiYer.Location = new System.Drawing.Point(325, 30);
            this.lblVerildigiYer.Name = "lblVerildigiYer";
            this.lblVerildigiYer.Size = new System.Drawing.Size(62, 13);
            this.lblVerildigiYer.TabIndex = 6;
            this.lblVerildigiYer.Text = "Verildiği Yer";
            // 
            // lblSiraNo
            // 
            this.lblSiraNo.AutoSize = true;
            this.lblSiraNo.Location = new System.Drawing.Point(11, 163);
            this.lblSiraNo.Name = "lblSiraNo";
            this.lblSiraNo.Size = new System.Drawing.Size(42, 13);
            this.lblSiraNo.TabIndex = 5;
            this.lblSiraNo.Text = "Sıra No";
            // 
            // lblAileSiraNo
            // 
            this.lblAileSiraNo.AutoSize = true;
            this.lblAileSiraNo.Location = new System.Drawing.Point(11, 137);
            this.lblAileSiraNo.Name = "lblAileSiraNo";
            this.lblAileSiraNo.Size = new System.Drawing.Size(62, 13);
            this.lblAileSiraNo.TabIndex = 4;
            this.lblAileSiraNo.Text = "Aile Sıra No";
            // 
            // lblCiltNo
            // 
            this.lblCiltNo.AutoSize = true;
            this.lblCiltNo.Location = new System.Drawing.Point(11, 111);
            this.lblCiltNo.Name = "lblCiltNo";
            this.lblCiltNo.Size = new System.Drawing.Size(38, 13);
            this.lblCiltNo.TabIndex = 3;
            this.lblCiltNo.Text = "Cilt No";
            // 
            // lblMahKoy
            // 
            this.lblMahKoy.AutoSize = true;
            this.lblMahKoy.Location = new System.Drawing.Point(11, 85);
            this.lblMahKoy.Name = "lblMahKoy";
            this.lblMahKoy.Size = new System.Drawing.Size(51, 13);
            this.lblMahKoy.TabIndex = 2;
            this.lblMahKoy.Text = "Mah/Köy";
            // 
            // lblIlce
            // 
            this.lblIlce.AutoSize = true;
            this.lblIlce.Location = new System.Drawing.Point(11, 55);
            this.lblIlce.Name = "lblIlce";
            this.lblIlce.Size = new System.Drawing.Size(24, 13);
            this.lblIlce.TabIndex = 1;
            this.lblIlce.Text = "İlçe";
            // 
            // lblIl
            // 
            this.lblIl.AutoSize = true;
            this.lblIl.Location = new System.Drawing.Point(11, 30);
            this.lblIl.Name = "lblIl";
            this.lblIl.Size = new System.Drawing.Size(12, 13);
            this.lblIl.TabIndex = 0;
            this.lblIl.Text = "İl";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(44, 364);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmNufusBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 391);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpNufusaKayitliOldugu);
            this.Controls.Add(this.grpKimlikBilgileri);
            this.Name = "frmNufusBilgileri";
            this.Text = "Nüfus Bilgileri";
            this.Load += new System.EventHandler(this.frmNufusBilgileri_Load);
            this.grpKimlikBilgileri.ResumeLayout(false);
            this.grpKimlikBilgileri.PerformLayout();
            this.grpNufusaKayitliOldugu.ResumeLayout(false);
            this.grpNufusaKayitliOldugu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKimlikBilgileri;
        private System.Windows.Forms.TextBox txtUyrugu;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtAnaAdi;
        private System.Windows.Forms.TextBox txtBabaAdi;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.TextBox txtNufusCuzdanNo;
        private System.Windows.Forms.Label lblUyrugu;
        private System.Windows.Forms.Label lblMedeniHali;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblAnaAdi;
        private System.Windows.Forms.Label lblBabaAdi;
        private System.Windows.Forms.Label lblTCKimlikNo;
        private System.Windows.Forms.Label lblNufusCuzdanNo;
        private System.Windows.Forms.GroupBox grpNufusaKayitliOldugu;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cmbMedeniHali;
        private System.Windows.Forms.TextBox txtVerildigiYer;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.TextBox txtAileSiraNo;
        private System.Windows.Forms.TextBox txtCiltNo;
        private System.Windows.Forms.TextBox txtMahKoy;
        private System.Windows.Forms.Label lblVerilisNedeni;
        private System.Windows.Forms.Label lblVerildigiYer;
        private System.Windows.Forms.Label lblSiraNo;
        private System.Windows.Forms.Label lblAileSiraNo;
        private System.Windows.Forms.Label lblCiltNo;
        private System.Windows.Forms.Label lblMahKoy;
        private System.Windows.Forms.Label lblIlce;
        private System.Windows.Forms.Label lblIl;
        private System.Windows.Forms.ComboBox cmbIlce;
        private System.Windows.Forms.ComboBox cmbVerilisNedeni;
        private System.Windows.Forms.ComboBox cmbIl;
        private System.Windows.Forms.Button btnKaydet;
    }
}