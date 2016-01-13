namespace UniversitePersonelOtomasyon
{
    partial class frmIzinBilgileri
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
            this.dataGridIzın = new System.Windows.Forms.DataGridView();
            this.bntIzınEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIzın)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridIzın);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Bilgileri";
            // 
            // dataGridIzın
            // 
            this.dataGridIzın.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridIzın.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIzın.Location = new System.Drawing.Point(6, 19);
            this.dataGridIzın.Name = "dataGridIzın";
            this.dataGridIzın.Size = new System.Drawing.Size(665, 237);
            this.dataGridIzın.TabIndex = 0;
            // 
            // bntIzınEkle
            // 
            this.bntIzınEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntIzınEkle.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.add;
            this.bntIzınEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntIzınEkle.Location = new System.Drawing.Point(625, 9);
            this.bntIzınEkle.Name = "bntIzınEkle";
            this.bntIzınEkle.Size = new System.Drawing.Size(58, 47);
            this.bntIzınEkle.TabIndex = 6;
            this.bntIzınEkle.UseVisualStyleBackColor = true;
            this.bntIzınEkle.Click += new System.EventHandler(this.bntIzınEkle_Click);
            // 
            // frmIzinBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 329);
            this.Controls.Add(this.bntIzınEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIzinBilgileri";
            this.Text = "frmIzinBilgileri";
            this.Load += new System.EventHandler(this.frmIzinBilgileri_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIzın)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridIzın;
        private System.Windows.Forms.Button bntIzınEkle;
    }
}