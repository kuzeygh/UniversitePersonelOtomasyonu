namespace UniversitePersonelOtomasyon
{
    partial class frmOzelNotGuncelle
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOzelNotDegistir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ozel Not ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Seçiniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOzelNotDegistir);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 338);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Özel Not Güncelleme";
            // 
            // btnOzelNotDegistir
            // 
            this.btnOzelNotDegistir.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.update;
            this.btnOzelNotDegistir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOzelNotDegistir.Location = new System.Drawing.Point(328, 21);
            this.btnOzelNotDegistir.Name = "btnOzelNotDegistir";
            this.btnOzelNotDegistir.Size = new System.Drawing.Size(58, 47);
            this.btnOzelNotDegistir.TabIndex = 8;
            this.btnOzelNotDegistir.UseVisualStyleBackColor = true;
            this.btnOzelNotDegistir.Click += new System.EventHandler(this.btnOzelNotDegistir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 242);
            this.textBox1.TabIndex = 2;
            // 
            // frmOzelNotGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 359);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOzelNotGuncelle";
            this.Text = "frmOzelNotGuncelle";
            this.Load += new System.EventHandler(this.frmOzelNotGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOzelNotDegistir;
    }
}