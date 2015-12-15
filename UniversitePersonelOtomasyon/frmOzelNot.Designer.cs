namespace UniversitePersonelOtomasyon
{
    partial class frmOzelNot
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
            this.txtOzelNot = new System.Windows.Forms.TextBox();
            this.bntOzelNotGuncelle = new System.Windows.Forms.Button();
            this.btnOzelNotEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOzelNot);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özel Not";
            // 
            // txtOzelNot
            // 
            this.txtOzelNot.Location = new System.Drawing.Point(6, 19);
            this.txtOzelNot.Multiline = true;
            this.txtOzelNot.Name = "txtOzelNot";
            this.txtOzelNot.Size = new System.Drawing.Size(665, 302);
            this.txtOzelNot.TabIndex = 0;
            // 
            // bntOzelNotGuncelle
            // 
            this.bntOzelNotGuncelle.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.update;
            this.bntOzelNotGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntOzelNotGuncelle.Location = new System.Drawing.Point(631, 7);
            this.bntOzelNotGuncelle.Name = "bntOzelNotGuncelle";
            this.bntOzelNotGuncelle.Size = new System.Drawing.Size(58, 47);
            this.bntOzelNotGuncelle.TabIndex = 7;
            this.bntOzelNotGuncelle.UseVisualStyleBackColor = true;
            this.bntOzelNotGuncelle.Click += new System.EventHandler(this.bntOzelNotGuncelle_Click);
            // 
            // btnOzelNotEkle
            // 
            this.btnOzelNotEkle.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.add;
            this.btnOzelNotEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOzelNotEkle.Location = new System.Drawing.Point(559, 7);
            this.btnOzelNotEkle.Name = "btnOzelNotEkle";
            this.btnOzelNotEkle.Size = new System.Drawing.Size(58, 47);
            this.btnOzelNotEkle.TabIndex = 6;
            this.btnOzelNotEkle.UseVisualStyleBackColor = true;
            this.btnOzelNotEkle.Click += new System.EventHandler(this.btnOzelNotEkle_Click);
            // 
            // frmOzelNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 395);
            this.Controls.Add(this.bntOzelNotGuncelle);
            this.Controls.Add(this.btnOzelNotEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOzelNot";
            this.Text = "frmOzelNot";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOzelNot;
        private System.Windows.Forms.Button btnOzelNotEkle;
        private System.Windows.Forms.Button bntOzelNotGuncelle;
    }
}