namespace UniversitePersonelOtomasyon
{
    partial class frmOgrenimBilgileriEkleme
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.EgitimBilgileri = new System.Windows.Forms.TabPage();
            this.btnKayit = new System.Windows.Forms.Button();
            this.dateMezuniyet = new System.Windows.Forms.DateTimePicker();
            this.dateGiris = new System.Windows.Forms.DateTimePicker();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOkulAdi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnYabanciDilEkle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateSinav = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYabanciDil = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.EgitimBilgileri.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.EgitimBilgileri);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(305, 247);
            this.tabControl1.TabIndex = 0;
            // 
            // EgitimBilgileri
            // 
            this.EgitimBilgileri.BackColor = System.Drawing.Color.Silver;
            this.EgitimBilgileri.Controls.Add(this.btnKayit);
            this.EgitimBilgileri.Controls.Add(this.dateMezuniyet);
            this.EgitimBilgileri.Controls.Add(this.dateGiris);
            this.EgitimBilgileri.Controls.Add(this.txtBolum);
            this.EgitimBilgileri.Controls.Add(this.label4);
            this.EgitimBilgileri.Controls.Add(this.label3);
            this.EgitimBilgileri.Controls.Add(this.label2);
            this.EgitimBilgileri.Controls.Add(this.label1);
            this.EgitimBilgileri.Controls.Add(this.txtOkulAdi);
            this.EgitimBilgileri.Location = new System.Drawing.Point(4, 22);
            this.EgitimBilgileri.Name = "EgitimBilgileri";
            this.EgitimBilgileri.Padding = new System.Windows.Forms.Padding(3);
            this.EgitimBilgileri.Size = new System.Drawing.Size(297, 221);
            this.EgitimBilgileri.TabIndex = 0;
            this.EgitimBilgileri.Text = "Eğitim";
            // 
            // btnKayit
            // 
            this.btnKayit.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.save;
            this.btnKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKayit.Location = new System.Drawing.Point(212, 157);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(71, 51);
            this.btnKayit.TabIndex = 9;
            this.btnKayit.UseVisualStyleBackColor = true;
            // 
            // dateMezuniyet
            // 
            this.dateMezuniyet.Location = new System.Drawing.Point(120, 118);
            this.dateMezuniyet.Name = "dateMezuniyet";
            this.dateMezuniyet.Size = new System.Drawing.Size(163, 20);
            this.dateMezuniyet.TabIndex = 8;
            // 
            // dateGiris
            // 
            this.dateGiris.Location = new System.Drawing.Point(120, 85);
            this.dateGiris.Name = "dateGiris";
            this.dateGiris.Size = new System.Drawing.Size(163, 20);
            this.dateGiris.TabIndex = 7;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(120, 56);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(163, 20);
            this.txtBolum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mezuniyet Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giriş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bölüm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Okul Adi";
            // 
            // txtOkulAdi
            // 
            this.txtOkulAdi.Location = new System.Drawing.Point(120, 21);
            this.txtOkulAdi.Name = "txtOkulAdi";
            this.txtOkulAdi.Size = new System.Drawing.Size(163, 20);
            this.txtOkulAdi.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.btnYabanciDilEkle);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtPuan);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dateSinav);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtYabanciDil);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(297, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yabancı Dil";
            // 
            // btnYabanciDilEkle
            // 
            this.btnYabanciDilEkle.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.save;
            this.btnYabanciDilEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYabanciDilEkle.Location = new System.Drawing.Point(208, 150);
            this.btnYabanciDilEkle.Name = "btnYabanciDilEkle";
            this.btnYabanciDilEkle.Size = new System.Drawing.Size(71, 51);
            this.btnYabanciDilEkle.TabIndex = 10;
            this.btnYabanciDilEkle.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Puan";
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(107, 109);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(172, 20);
            this.txtPuan.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sınav Tarihi";
            // 
            // dateSinav
            // 
            this.dateSinav.Location = new System.Drawing.Point(107, 72);
            this.dateSinav.Name = "dateSinav";
            this.dateSinav.Size = new System.Drawing.Size(172, 20);
            this.dateSinav.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Yabancı Dil";
            // 
            // txtYabanciDil
            // 
            this.txtYabanciDil.Location = new System.Drawing.Point(107, 34);
            this.txtYabanciDil.Name = "txtYabanciDil";
            this.txtYabanciDil.Size = new System.Drawing.Size(172, 20);
            this.txtYabanciDil.TabIndex = 0;
            // 
            // frmOgrenimBilgileriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 245);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmOgrenimBilgileriEkleme";
            this.Text = "frmOgrenimBilgileriEkleme";
            this.tabControl1.ResumeLayout(false);
            this.EgitimBilgileri.ResumeLayout(false);
            this.EgitimBilgileri.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage EgitimBilgileri;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.DateTimePicker dateMezuniyet;
        private System.Windows.Forms.DateTimePicker dateGiris;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOkulAdi;
        private System.Windows.Forms.Button btnYabanciDilEkle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateSinav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYabanciDil;
    }
}