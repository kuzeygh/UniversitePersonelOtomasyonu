namespace UniversitePersonelOtomasyon
{
    partial class frmIzinEkle
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
            this.cmbIzinTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIzinBilgisi = new System.Windows.Forms.TextBox();
            this.dateIzinBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateIzinBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIzınEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzınEkle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateIzinBitis);
            this.groupBox1.Controls.Add(this.dateIzinBaslangic);
            this.groupBox1.Controls.Add(this.txtIzinBilgisi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbIzinTuru);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Ekle";
            // 
            // cmbIzinTuru
            // 
            this.cmbIzinTuru.FormattingEnabled = true;
            this.cmbIzinTuru.Location = new System.Drawing.Point(121, 36);
            this.cmbIzinTuru.Name = "cmbIzinTuru";
            this.cmbIzinTuru.Size = new System.Drawing.Size(158, 21);
            this.cmbIzinTuru.TabIndex = 0;
            this.cmbIzinTuru.Text = "Seçiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İzin Türü";
            // 
            // txtIzinBilgisi
            // 
            this.txtIzinBilgisi.Location = new System.Drawing.Point(121, 133);
            this.txtIzinBilgisi.Multiline = true;
            this.txtIzinBilgisi.Name = "txtIzinBilgisi";
            this.txtIzinBilgisi.Size = new System.Drawing.Size(158, 58);
            this.txtIzinBilgisi.TabIndex = 2;
            // 
            // dateIzinBaslangic
            // 
            this.dateIzinBaslangic.Location = new System.Drawing.Point(121, 69);
            this.dateIzinBaslangic.Name = "dateIzinBaslangic";
            this.dateIzinBaslangic.Size = new System.Drawing.Size(158, 20);
            this.dateIzinBaslangic.TabIndex = 3;
            // 
            // dateIzinBitis
            // 
            this.dateIzinBitis.Location = new System.Drawing.Point(121, 101);
            this.dateIzinBitis.Name = "dateIzinBitis";
            this.dateIzinBitis.Size = new System.Drawing.Size(158, 20);
            this.dateIzinBitis.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Başlangıç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bitiş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "İzin Bilgisi";
            // 
            // btnIzınEkle
            // 
            this.btnIzınEkle.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.save;
            this.btnIzınEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIzınEkle.Location = new System.Drawing.Point(208, 203);
            this.btnIzınEkle.Name = "btnIzınEkle";
            this.btnIzınEkle.Size = new System.Drawing.Size(71, 51);
            this.btnIzınEkle.TabIndex = 10;
            this.btnIzınEkle.UseVisualStyleBackColor = true;
            // 
            // frmIzinEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 284);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIzinEkle";
            this.Text = "frmIzinEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateIzinBitis;
        private System.Windows.Forms.DateTimePicker dateIzinBaslangic;
        private System.Windows.Forms.TextBox txtIzinBilgisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIzinTuru;
        private System.Windows.Forms.Button btnIzınEkle;
    }
}