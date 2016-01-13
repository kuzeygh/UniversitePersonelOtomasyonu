namespace UniversitePersonelOtomasyon.Formlar.i
{
    partial class frmAkademikPersonelSayi
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
            this.dtgAkademikPersonelSayisi = new System.Windows.Forms.DataGridView();
            this.Fakulte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YarDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrGor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uzman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Okutman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArGor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cevirici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EgOgPl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Toplam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAkademikPersonelSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAkademikPersonelSayisi
            // 
            this.dtgAkademikPersonelSayisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAkademikPersonelSayisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAkademikPersonelSayisi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fakulte,
            this.Prof,
            this.Doc,
            this.YarDoc,
            this.OgrGor,
            this.Uzman,
            this.Okutman,
            this.ArGor,
            this.Cevirici,
            this.EgOgPl,
            this.Toplam});
            this.dtgAkademikPersonelSayisi.Location = new System.Drawing.Point(12, 12);
            this.dtgAkademikPersonelSayisi.Name = "dtgAkademikPersonelSayisi";
            this.dtgAkademikPersonelSayisi.Size = new System.Drawing.Size(756, 463);
            this.dtgAkademikPersonelSayisi.TabIndex = 1;
            // 
            // Fakulte
            // 
            this.Fakulte.HeaderText = "Fakülte";
            this.Fakulte.Name = "Fakulte";
            // 
            // Prof
            // 
            this.Prof.HeaderText = "Profesör";
            this.Prof.Name = "Prof";
            // 
            // Doc
            // 
            this.Doc.HeaderText = "Doçent";
            this.Doc.Name = "Doc";
            // 
            // YarDoc
            // 
            this.YarDoc.HeaderText = "Yrd.Doç";
            this.YarDoc.Name = "YarDoc";
            // 
            // OgrGor
            // 
            this.OgrGor.HeaderText = "Öğr.Gör";
            this.OgrGor.Name = "OgrGor";
            // 
            // Uzman
            // 
            this.Uzman.HeaderText = "Uzman";
            this.Uzman.Name = "Uzman";
            // 
            // Okutman
            // 
            this.Okutman.HeaderText = "Okutman";
            this.Okutman.Name = "Okutman";
            // 
            // ArGor
            // 
            this.ArGor.HeaderText = "Ar.Gör";
            this.ArGor.Name = "ArGor";
            // 
            // Cevirici
            // 
            this.Cevirici.HeaderText = "Çevirici";
            this.Cevirici.Name = "Cevirici";
            // 
            // EgOgPl
            // 
            this.EgOgPl.HeaderText = "Eğ.Öğ.Pl";
            this.EgOgPl.Name = "EgOgPl";
            // 
            // Toplam
            // 
            this.Toplam.HeaderText = "Toplam";
            this.Toplam.Name = "Toplam";
            // 
            // frmAkademikPersonelSayi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 486);
            this.Controls.Add(this.dtgAkademikPersonelSayisi);
            this.Name = "frmAkademikPersonelSayi";
            this.Text = "frmAkademikPersonelSayi";
            this.Load += new System.EventHandler(this.frmAkademikPersonelSayi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAkademikPersonelSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAkademikPersonelSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fakulte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn YarDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrGor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uzman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Okutman;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArGor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cevirici;
        private System.Windows.Forms.DataGridViewTextBoxColumn EgOgPl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Toplam;
    }
}