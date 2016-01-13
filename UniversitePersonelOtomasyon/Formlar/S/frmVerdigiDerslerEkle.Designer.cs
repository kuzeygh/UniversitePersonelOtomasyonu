namespace UniversitePersonelOtomasyon.Formlar.S
{
    partial class frmVerdigiDerslerEkle
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
            this.txtDers = new System.Windows.Forms.TextBox();
            this.txtBaslangicSaat = new System.Windows.Forms.TextBox();
            this.txtBitisSaat = new System.Windows.Forms.TextBox();
            this.cmbDersGunu = new System.Windows.Forms.ComboBox();
            this.btnVerdigiDersEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDers
            // 
            this.txtDers.Location = new System.Drawing.Point(100, 28);
            this.txtDers.Name = "txtDers";
            this.txtDers.Size = new System.Drawing.Size(157, 20);
            this.txtDers.TabIndex = 0;
            // 
            // txtBaslangicSaat
            // 
            this.txtBaslangicSaat.Location = new System.Drawing.Point(100, 59);
            this.txtBaslangicSaat.Name = "txtBaslangicSaat";
            this.txtBaslangicSaat.Size = new System.Drawing.Size(157, 20);
            this.txtBaslangicSaat.TabIndex = 1;
            // 
            // txtBitisSaat
            // 
            this.txtBitisSaat.Location = new System.Drawing.Point(100, 90);
            this.txtBitisSaat.Name = "txtBitisSaat";
            this.txtBitisSaat.Size = new System.Drawing.Size(157, 20);
            this.txtBitisSaat.TabIndex = 2;
            // 
            // cmbDersGunu
            // 
            this.cmbDersGunu.FormattingEnabled = true;
            this.cmbDersGunu.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma"});
            this.cmbDersGunu.Location = new System.Drawing.Point(100, 119);
            this.cmbDersGunu.Name = "cmbDersGunu";
            this.cmbDersGunu.Size = new System.Drawing.Size(157, 21);
            this.cmbDersGunu.TabIndex = 3;
            this.cmbDersGunu.Text = "Seçiniz";
            // 
            // btnVerdigiDersEkle
            // 
            this.btnVerdigiDersEkle.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.save;
            this.btnVerdigiDersEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerdigiDersEkle.Location = new System.Drawing.Point(186, 184);
            this.btnVerdigiDersEkle.Name = "btnVerdigiDersEkle";
            this.btnVerdigiDersEkle.Size = new System.Drawing.Size(71, 51);
            this.btnVerdigiDersEkle.TabIndex = 11;
            this.btnVerdigiDersEkle.UseVisualStyleBackColor = true;
            this.btnVerdigiDersEkle.Click += new System.EventHandler(this.btnVerdigiDersEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Baslangic Saati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bitiş Saati";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ders Günü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sınıf";
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(100, 149);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(157, 21);
            this.cmbSinif.TabIndex = 16;
            this.cmbSinif.Text = "Seçiniz";
            // 
            // frmVerdigiDerslerEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 251);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSinif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerdigiDersEkle);
            this.Controls.Add(this.cmbDersGunu);
            this.Controls.Add(this.txtBitisSaat);
            this.Controls.Add(this.txtBaslangicSaat);
            this.Controls.Add(this.txtDers);
            this.Name = "frmVerdigiDerslerEkle";
            this.Text = "frmVerdigiDerslerEkle";
            this.Load += new System.EventHandler(this.frmVerdigiDerslerEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDers;
        private System.Windows.Forms.TextBox txtBaslangicSaat;
        private System.Windows.Forms.TextBox txtBitisSaat;
        private System.Windows.Forms.ComboBox cmbDersGunu;
        private System.Windows.Forms.Button btnVerdigiDersEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSinif;
    }
}