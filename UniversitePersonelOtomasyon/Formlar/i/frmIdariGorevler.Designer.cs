namespace UniversitePersonelOtomasyon.Formlar.i
{
    partial class frmIdariGorevler
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
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.grpGorevBilgileri = new System.Windows.Forms.GroupBox();
            this.dgvGorev = new System.Windows.Forms.DataGridView();
            this.GorevAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaslamaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BitisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpGorevBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorev)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Location = new System.Drawing.Point(542, 251);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(153, 23);
            this.btnGorevEkle.TabIndex = 3;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // grpGorevBilgileri
            // 
            this.grpGorevBilgileri.Controls.Add(this.dgvGorev);
            this.grpGorevBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpGorevBilgileri.Name = "grpGorevBilgileri";
            this.grpGorevBilgileri.Size = new System.Drawing.Size(683, 233);
            this.grpGorevBilgileri.TabIndex = 2;
            this.grpGorevBilgileri.TabStop = false;
            this.grpGorevBilgileri.Text = "Görev Bilgileri";
            // 
            // dgvGorev
            // 
            this.dgvGorev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGorev.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GorevAdi,
            this.BaslamaTarihi,
            this.BitisTarihi});
            this.dgvGorev.Location = new System.Drawing.Point(12, 19);
            this.dgvGorev.Name = "dgvGorev";
            this.dgvGorev.Size = new System.Drawing.Size(671, 208);
            this.dgvGorev.TabIndex = 1;
            // 
            // GorevAdi
            // 
            this.GorevAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GorevAdi.HeaderText = "Görev Adı";
            this.GorevAdi.Name = "GorevAdi";
            // 
            // BaslamaTarihi
            // 
            this.BaslamaTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BaslamaTarihi.HeaderText = "BaşlamaTarihi";
            this.BaslamaTarihi.Name = "BaslamaTarihi";
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BitisTarihi.HeaderText = "Bitiş Tarihi";
            this.BitisTarihi.Name = "BitisTarihi";
            // 
            // frmIdariGorevler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 291);
            this.Controls.Add(this.btnGorevEkle);
            this.Controls.Add(this.grpGorevBilgileri);
            this.Name = "frmIdariGorevler";
            this.Text = "frmIdariGorevler";
            this.Load += new System.EventHandler(this.frmIdariGorevler_Load);
            this.grpGorevBilgileri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGorevEkle;
        private System.Windows.Forms.GroupBox grpGorevBilgileri;
        private System.Windows.Forms.DataGridView dgvGorev;
        private System.Windows.Forms.DataGridViewTextBoxColumn GorevAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaslamaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BitisTarihi;
    }
}