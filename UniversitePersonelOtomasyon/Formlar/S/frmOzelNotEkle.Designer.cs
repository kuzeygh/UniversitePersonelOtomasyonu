namespace UniversitePersonelOtomasyon
{
    partial class frmOzelNotEkle
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
            this.txtOzelNotSayfa = new System.Windows.Forms.TextBox();
            this.btnOzelNotKayit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOzelNotSayfa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özel Not Ekle";
            // 
            // txtOzelNotSayfa
            // 
            this.txtOzelNotSayfa.Location = new System.Drawing.Point(6, 19);
            this.txtOzelNotSayfa.Multiline = true;
            this.txtOzelNotSayfa.Name = "txtOzelNotSayfa";
            this.txtOzelNotSayfa.Size = new System.Drawing.Size(352, 243);
            this.txtOzelNotSayfa.TabIndex = 0;
            // 
            // btnOzelNotKayit
            // 
            this.btnOzelNotKayit.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.save;
            this.btnOzelNotKayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOzelNotKayit.Location = new System.Drawing.Point(299, 284);
            this.btnOzelNotKayit.Name = "btnOzelNotKayit";
            this.btnOzelNotKayit.Size = new System.Drawing.Size(71, 51);
            this.btnOzelNotKayit.TabIndex = 10;
            this.btnOzelNotKayit.UseVisualStyleBackColor = true;
            this.btnOzelNotKayit.Click += new System.EventHandler(this.btnOzelNotKayit_Click);
            // 
            // frmOzelNotEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 341);
            this.Controls.Add(this.btnOzelNotKayit);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOzelNotEkle";
            this.Text = "frmOzelNotEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOzelNotSayfa;
        private System.Windows.Forms.Button btnOzelNotKayit;
    }
}