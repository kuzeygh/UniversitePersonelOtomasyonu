namespace UniversitePersonelOtomasyon.Formlar.S
{
    partial class frmCezaEkle
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
            this.txtCeza = new System.Windows.Forms.TextBox();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.cmbPersonelId = new System.Windows.Forms.ComboBox();
            this.btnCezaEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCeza
            // 
            this.txtCeza.Location = new System.Drawing.Point(110, 43);
            this.txtCeza.Name = "txtCeza";
            this.txtCeza.Size = new System.Drawing.Size(161, 20);
            this.txtCeza.TabIndex = 0;
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(110, 74);
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.Size = new System.Drawing.Size(161, 20);
            this.txtGunSayisi.TabIndex = 1;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.Location = new System.Drawing.Point(110, 108);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(161, 20);
            this.dateBaslangic.TabIndex = 2;
            // 
            // dateBitis
            // 
            this.dateBitis.Location = new System.Drawing.Point(110, 147);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(161, 20);
            this.dateBitis.TabIndex = 3;
            this.dateBitis.ValueChanged += new System.EventHandler(this.dateBitis_ValueChanged);
            // 
            // cmbPersonelId
            // 
            this.cmbPersonelId.FormattingEnabled = true;
            this.cmbPersonelId.Location = new System.Drawing.Point(110, 12);
            this.cmbPersonelId.Name = "cmbPersonelId";
            this.cmbPersonelId.Size = new System.Drawing.Size(161, 21);
            this.cmbPersonelId.TabIndex = 4;
            this.cmbPersonelId.Text = "Seçiniz";
            // 
            // btnCezaEkle
            // 
            this.btnCezaEkle.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.save;
            this.btnCezaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCezaEkle.Location = new System.Drawing.Point(200, 185);
            this.btnCezaEkle.Name = "btnCezaEkle";
            this.btnCezaEkle.Size = new System.Drawing.Size(71, 51);
            this.btnCezaEkle.TabIndex = 12;
            this.btnCezaEkle.UseVisualStyleBackColor = true;
            this.btnCezaEkle.Click += new System.EventHandler(this.btnCezaEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Personel ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ceza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gün Sayisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Başlangıç Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Bitiş Tarihi";
            // 
            // frmCezaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 251);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCezaEkle);
            this.Controls.Add(this.cmbPersonelId);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.dateBaslangic);
            this.Controls.Add(this.txtGunSayisi);
            this.Controls.Add(this.txtCeza);
            this.Name = "frmCezaEkle";
            this.Text = "frmCezaEkle";
            this.Load += new System.EventHandler(this.frmCezaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCeza;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.ComboBox cmbPersonelId;
        private System.Windows.Forms.Button btnCezaEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}