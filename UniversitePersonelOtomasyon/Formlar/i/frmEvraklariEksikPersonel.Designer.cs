namespace UniversitePersonelOtomasyon.Formlar.i
{
    partial class frmEvraklariEksikPersonel
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
            this.lblEvrakTipi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRaporGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEvrakTipi
            // 
            this.lblEvrakTipi.AutoSize = true;
            this.lblEvrakTipi.Location = new System.Drawing.Point(12, 37);
            this.lblEvrakTipi.Name = "lblEvrakTipi";
            this.lblEvrakTipi.Size = new System.Drawing.Size(55, 13);
            this.lblEvrakTipi.TabIndex = 1;
            this.lblEvrakTipi.Text = "Evrak Tipi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İş Başvuru Formu",
            "Nüfus Cüzdanı Fotokopisi",
            "Vesikalık",
            "İkametgah",
            "Sağlık Raporu",
            "Lisans Başvurusu"});
            this.comboBox1.Location = new System.Drawing.Point(90, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btnRaporGetir
            // 
            this.btnRaporGetir.Location = new System.Drawing.Point(90, 97);
            this.btnRaporGetir.Name = "btnRaporGetir";
            this.btnRaporGetir.Size = new System.Drawing.Size(75, 23);
            this.btnRaporGetir.TabIndex = 3;
            this.btnRaporGetir.Text = "Rapor Getir";
            this.btnRaporGetir.UseVisualStyleBackColor = true;
            this.btnRaporGetir.Click += new System.EventHandler(this.btnRaporGetir_Click);
            // 
            // frmEvraklariEksikPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnRaporGetir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblEvrakTipi);
            this.Name = "frmEvraklariEksikPersonel";
            this.Text = "Evrakları Eksik Personel Listesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEvrakTipi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnRaporGetir;
    }
}