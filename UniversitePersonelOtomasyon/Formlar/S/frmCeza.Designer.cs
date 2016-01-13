namespace UniversitePersonelOtomasyon.Formlar.S
{
    partial class frmCeza
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCezaEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ceza Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 285);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnCezaEkle
            // 
            this.btnCezaEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCezaEkle.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.add;
            this.btnCezaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCezaEkle.Location = new System.Drawing.Point(556, 12);
            this.btnCezaEkle.Name = "btnCezaEkle";
            this.btnCezaEkle.Size = new System.Drawing.Size(58, 47);
            this.btnCezaEkle.TabIndex = 8;
            this.btnCezaEkle.UseVisualStyleBackColor = true;
            this.btnCezaEkle.Click += new System.EventHandler(this.btnCezaEkle_Click);
            // 
            // frmCeza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 386);
            this.Controls.Add(this.btnCezaEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCeza";
            this.Text = "frmCeza";
            this.Load += new System.EventHandler(this.frmCeza_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCezaEkle;
    }
}