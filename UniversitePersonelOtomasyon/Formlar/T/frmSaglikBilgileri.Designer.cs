namespace UniversitePersonelOtomasyon.Formlar.T
{
    partial class frmSaglikBilgileri
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
            this.txtDerece = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoHayir = new System.Windows.Forms.RadioButton();
            this.rdoEvet = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDerece);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoHayir);
            this.groupBox1.Controls.Add(this.rdoEvet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sağlık Bilgileri";
            // 
            // txtDerece
            // 
            this.txtDerece.Location = new System.Drawing.Point(128, 64);
            this.txtDerece.Name = "txtDerece";
            this.txtDerece.Size = new System.Drawing.Size(53, 20);
            this.txtDerece.TabIndex = 5;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(24, 105);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(204, 53);
            this.txtAciklama.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sakatlık Derecesi %";
            // 
            // rdoHayir
            // 
            this.rdoHayir.AutoSize = true;
            this.rdoHayir.Location = new System.Drawing.Point(179, 36);
            this.rdoHayir.Name = "rdoHayir";
            this.rdoHayir.Size = new System.Drawing.Size(49, 17);
            this.rdoHayir.TabIndex = 2;
            this.rdoHayir.TabStop = true;
            this.rdoHayir.Text = "Hayır";
            this.rdoHayir.UseVisualStyleBackColor = true;
            // 
            // rdoEvet
            // 
            this.rdoEvet.AutoSize = true;
            this.rdoEvet.Location = new System.Drawing.Point(114, 36);
            this.rdoEvet.Name = "rdoEvet";
            this.rdoEvet.Size = new System.Drawing.Size(47, 17);
            this.rdoEvet.TabIndex = 1;
            this.rdoEvet.TabStop = true;
            this.rdoEvet.Text = "Evet";
            this.rdoEvet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sakatlığı var mı? ";
            // 
            // tbnKaydet
            // 
            this.tbnKaydet.Location = new System.Drawing.Point(140, 226);
            this.tbnKaydet.Name = "tbnKaydet";
            this.tbnKaydet.Size = new System.Drawing.Size(75, 23);
            this.tbnKaydet.TabIndex = 1;
            this.tbnKaydet.Text = "button1";
            this.tbnKaydet.UseVisualStyleBackColor = true;
            this.tbnKaydet.Click += new System.EventHandler(this.tbnKaydet_Click);
            // 
            // frmSaglikBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 264);
            this.Controls.Add(this.tbnKaydet);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSaglikBilgileri";
            this.Text = "frmSaglikBilgileri";
            this.Load += new System.EventHandler(this.frmSaglikBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoHayir;
        private System.Windows.Forms.RadioButton rdoEvet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDerece;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tbnKaydet;
    }
}