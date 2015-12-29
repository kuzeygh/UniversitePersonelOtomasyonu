namespace UniversitePersonelOtomasyon
{
    partial class frmKullaniciEkle
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
            this.btnKullaniciEkleme = new System.Windows.Forms.Button();
            this.chckFakulteSekreteri = new System.Windows.Forms.CheckBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKullaniciEkleme);
            this.groupBox1.Controls.Add(this.chckFakulteSekreteri);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanici Bilgileri";
            // 
            // btnKullaniciEkleme
            // 
            this.btnKullaniciEkleme.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.save;
            this.btnKullaniciEkleme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKullaniciEkleme.Location = new System.Drawing.Point(183, 135);
            this.btnKullaniciEkleme.Name = "btnKullaniciEkleme";
            this.btnKullaniciEkleme.Size = new System.Drawing.Size(71, 51);
            this.btnKullaniciEkleme.TabIndex = 11;
            this.btnKullaniciEkleme.UseVisualStyleBackColor = true;
            this.btnKullaniciEkleme.Click += new System.EventHandler(this.btnKullaniciEkleme_Click);
            // 
            // chckFakulteSekreteri
            // 
            this.chckFakulteSekreteri.AutoSize = true;
            this.chckFakulteSekreteri.Location = new System.Drawing.Point(101, 105);
            this.chckFakulteSekreteri.Name = "chckFakulteSekreteri";
            this.chckFakulteSekreteri.Size = new System.Drawing.Size(106, 17);
            this.chckFakulteSekreteri.TabIndex = 4;
            this.chckFakulteSekreteri.Text = "Fakülte Sekreteri";
            this.chckFakulteSekreteri.UseVisualStyleBackColor = true;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(101, 68);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(153, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(101, 32);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(153, 20);
            this.txtKullaniciAdi.TabIndex = 0;
            // 
            // frmKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 222);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKullaniciEkle";
            this.Text = "frmKullaniciEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chckFakulteSekreteri;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnKullaniciEkleme;
    }
}