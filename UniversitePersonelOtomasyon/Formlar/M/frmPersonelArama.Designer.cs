namespace UniversitePersonelOtomasyon.Formlar.M
{
    partial class frmPersonelArama
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
            this.Ara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dtgSearchResult = new System.Windows.Forms.DataGridView();
            this.btnDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // Ara
            // 
            this.Ara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ara.Location = new System.Drawing.Point(415, 21);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(75, 23);
            this.Ara.TabIndex = 0;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(68, 21);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(170, 20);
            this.txtAd.TabIndex = 2;
            // 
            // dtgSearchResult
            // 
            this.dtgSearchResult.AllowUserToAddRows = false;
            this.dtgSearchResult.AllowUserToDeleteRows = false;
            this.dtgSearchResult.AllowUserToResizeColumns = false;
            this.dtgSearchResult.AllowUserToResizeRows = false;
            this.dtgSearchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSearchResult.Location = new System.Drawing.Point(15, 63);
            this.dtgSearchResult.Name = "dtgSearchResult";
            this.dtgSearchResult.ReadOnly = true;
            this.dtgSearchResult.Size = new System.Drawing.Size(556, 347);
            this.dtgSearchResult.TabIndex = 3;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(496, 21);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 4;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // frmPersonelArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 422);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.dtgSearchResult);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ara);
            this.Name = "frmPersonelArama";
            this.Text = "Personel Arama";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DataGridView dtgSearchResult;
        private System.Windows.Forms.Button btnDuzenle;
    }
}