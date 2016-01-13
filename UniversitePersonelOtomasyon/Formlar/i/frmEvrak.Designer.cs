namespace UniversitePersonelOtomasyon.Formlar.i
{
    partial class frmEvrak
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
            this.grpPersonelEvrakDurumu = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbLisansBasvurusu = new System.Windows.Forms.CheckBox();
            this.cbSaglikRaporu = new System.Windows.Forms.CheckBox();
            this.cbVesikalik = new System.Windows.Forms.CheckBox();
            this.cbNufusCuzdaniFotokopisi = new System.Windows.Forms.CheckBox();
            this.cbIsBasvuruFormu = new System.Windows.Forms.CheckBox();
            this.grpPersonelEvrakDurumu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPersonelEvrakDurumu
            // 
            this.grpPersonelEvrakDurumu.Controls.Add(this.btnGuncelle);
            this.grpPersonelEvrakDurumu.Controls.Add(this.cbLisansBasvurusu);
            this.grpPersonelEvrakDurumu.Controls.Add(this.cbSaglikRaporu);
            this.grpPersonelEvrakDurumu.Controls.Add(this.cbVesikalik);
            this.grpPersonelEvrakDurumu.Controls.Add(this.cbNufusCuzdaniFotokopisi);
            this.grpPersonelEvrakDurumu.Controls.Add(this.cbIsBasvuruFormu);
            this.grpPersonelEvrakDurumu.Location = new System.Drawing.Point(12, 12);
            this.grpPersonelEvrakDurumu.Name = "grpPersonelEvrakDurumu";
            this.grpPersonelEvrakDurumu.Size = new System.Drawing.Size(387, 238);
            this.grpPersonelEvrakDurumu.TabIndex = 1;
            this.grpPersonelEvrakDurumu.TabStop = false;
            this.grpPersonelEvrakDurumu.Text = "Personel Evrak Durumu";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(188, 132);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(93, 23);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // cbLisansBasvurusu
            // 
            this.cbLisansBasvurusu.AutoSize = true;
            this.cbLisansBasvurusu.Location = new System.Drawing.Point(188, 86);
            this.cbLisansBasvurusu.Name = "cbLisansBasvurusu";
            this.cbLisansBasvurusu.Size = new System.Drawing.Size(109, 17);
            this.cbLisansBasvurusu.TabIndex = 4;
            this.cbLisansBasvurusu.Text = "Lisans Başvurusu";
            this.cbLisansBasvurusu.UseVisualStyleBackColor = true;
            // 
            // cbSaglikRaporu
            // 
            this.cbSaglikRaporu.AutoSize = true;
            this.cbSaglikRaporu.Location = new System.Drawing.Point(188, 31);
            this.cbSaglikRaporu.Name = "cbSaglikRaporu";
            this.cbSaglikRaporu.Size = new System.Drawing.Size(93, 17);
            this.cbSaglikRaporu.TabIndex = 3;
            this.cbSaglikRaporu.Text = "Sağlık Raporu";
            this.cbSaglikRaporu.UseVisualStyleBackColor = true;
            // 
            // cbVesikalik
            // 
            this.cbVesikalik.AutoSize = true;
            this.cbVesikalik.Location = new System.Drawing.Point(6, 136);
            this.cbVesikalik.Name = "cbVesikalik";
            this.cbVesikalik.Size = new System.Drawing.Size(68, 17);
            this.cbVesikalik.TabIndex = 2;
            this.cbVesikalik.Text = "Vesikalık";
            this.cbVesikalik.UseVisualStyleBackColor = true;
            // 
            // cbNufusCuzdaniFotokopisi
            // 
            this.cbNufusCuzdaniFotokopisi.AutoSize = true;
            this.cbNufusCuzdaniFotokopisi.Location = new System.Drawing.Point(6, 86);
            this.cbNufusCuzdaniFotokopisi.Name = "cbNufusCuzdaniFotokopisi";
            this.cbNufusCuzdaniFotokopisi.Size = new System.Drawing.Size(146, 17);
            this.cbNufusCuzdaniFotokopisi.TabIndex = 1;
            this.cbNufusCuzdaniFotokopisi.Text = "Nüfus Cüzdanı Fotokopisi";
            this.cbNufusCuzdaniFotokopisi.UseVisualStyleBackColor = true;
            // 
            // cbIsBasvuruFormu
            // 
            this.cbIsBasvuruFormu.AutoSize = true;
            this.cbIsBasvuruFormu.Location = new System.Drawing.Point(6, 31);
            this.cbIsBasvuruFormu.Name = "cbIsBasvuruFormu";
            this.cbIsBasvuruFormu.Size = new System.Drawing.Size(108, 17);
            this.cbIsBasvuruFormu.TabIndex = 0;
            this.cbIsBasvuruFormu.Text = "İş Başvuru Formu";
            this.cbIsBasvuruFormu.UseVisualStyleBackColor = true;
            // 
            // frmEvrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 262);
            this.Controls.Add(this.grpPersonelEvrakDurumu);
            this.Name = "frmEvrak";
            this.Text = "frmEvrak";
            this.Load += new System.EventHandler(this.frmEvrak_Load);
            this.grpPersonelEvrakDurumu.ResumeLayout(false);
            this.grpPersonelEvrakDurumu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPersonelEvrakDurumu;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.CheckBox cbLisansBasvurusu;
        private System.Windows.Forms.CheckBox cbSaglikRaporu;
        private System.Windows.Forms.CheckBox cbVesikalik;
        private System.Windows.Forms.CheckBox cbNufusCuzdaniFotokopisi;
        private System.Windows.Forms.CheckBox cbIsBasvuruFormu;
    }
}