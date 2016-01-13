namespace UniversitePersonelOtomasyon
{
    partial class frmBilimselFaaliyetler
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
            this.dataGridFaaliyetler = new System.Windows.Forms.DataGridView();
            this.btnFaaliyetEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaaliyetler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridFaaliyetler);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilimsel Faaliyetler";
            // 
            // dataGridFaaliyetler
            // 
            this.dataGridFaaliyetler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFaaliyetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFaaliyetler.Location = new System.Drawing.Point(6, 19);
            this.dataGridFaaliyetler.Name = "dataGridFaaliyetler";
            this.dataGridFaaliyetler.Size = new System.Drawing.Size(648, 249);
            this.dataGridFaaliyetler.TabIndex = 0;
            // 
            // btnFaaliyetEkle
            // 
            this.btnFaaliyetEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFaaliyetEkle.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.add;
            this.btnFaaliyetEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFaaliyetEkle.Location = new System.Drawing.Point(614, 11);
            this.btnFaaliyetEkle.Name = "btnFaaliyetEkle";
            this.btnFaaliyetEkle.Size = new System.Drawing.Size(58, 47);
            this.btnFaaliyetEkle.TabIndex = 7;
            this.btnFaaliyetEkle.UseVisualStyleBackColor = true;
            this.btnFaaliyetEkle.Click += new System.EventHandler(this.btnFaaliyetEkle_Click);
            // 
            // frmBilimselFaaliyetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 350);
            this.Controls.Add(this.btnFaaliyetEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBilimselFaaliyetler";
            this.Text = "frmBilimselFaaliyetler";
            this.Load += new System.EventHandler(this.frmBilimselFaaliyetler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFaaliyetler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridFaaliyetler;
        private System.Windows.Forms.Button btnFaaliyetEkle;
    }
}