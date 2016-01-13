namespace UniversitePersonelOtomasyon.Formlar.S
{
    partial class frmVerdigiDersler
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
            this.dataGridDersler = new System.Windows.Forms.DataGridView();
            this.btnDersVer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridDersler);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verdiği Dersler";
            // 
            // dataGridDersler
            // 
            this.dataGridDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDersler.Location = new System.Drawing.Point(6, 19);
            this.dataGridDersler.Name = "dataGridDersler";
            this.dataGridDersler.Size = new System.Drawing.Size(599, 245);
            this.dataGridDersler.TabIndex = 1;
            // 
            // btnDersVer
            // 
            this.btnDersVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDersVer.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.add;
            this.btnDersVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDersVer.Location = new System.Drawing.Point(559, 23);
            this.btnDersVer.Name = "btnDersVer";
            this.btnDersVer.Size = new System.Drawing.Size(58, 47);
            this.btnDersVer.TabIndex = 8;
            this.btnDersVer.UseVisualStyleBackColor = true;
            // 
            // frmVerdigiDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 356);
            this.Controls.Add(this.btnDersVer);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVerdigiDersler";
            this.Text = "frmVerdigiDersler";
            this.Load += new System.EventHandler(this.frmVerdigiDersler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDersler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridDersler;
        private System.Windows.Forms.Button btnDersVer;
    }
}