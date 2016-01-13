namespace UniversitePersonelOtomasyon
{
    partial class frmBolumAnaBilimSayisalTablosu
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
            this.dataGridSayisalTablo = new System.Windows.Forms.DataGridView();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.cmbBolumSec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFakulteSec = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSayisalTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridSayisalTablo);
            this.groupBox1.Controls.Add(this.btnSorgula);
            this.groupBox1.Controls.Add(this.cmbBolumSec);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbFakulteSec);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bölüm / Ana Bilim Sayısal Tablosu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridSayisalTablo
            // 
            this.dataGridSayisalTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSayisalTablo.Location = new System.Drawing.Point(9, 117);
            this.dataGridSayisalTablo.Name = "dataGridSayisalTablo";
            this.dataGridSayisalTablo.Size = new System.Drawing.Size(681, 323);
            this.dataGridSayisalTablo.TabIndex = 5;
            // 
            // btnSorgula
            // 
            this.btnSorgula.BackgroundImage = global::UniversitePersonelOtomasyon.Properties.Resources.search;
            this.btnSorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSorgula.Location = new System.Drawing.Point(280, 29);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(65, 59);
            this.btnSorgula.TabIndex = 4;
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // cmbBolumSec
            // 
            this.cmbBolumSec.FormattingEnabled = true;
            this.cmbBolumSec.Location = new System.Drawing.Point(78, 67);
            this.cmbBolumSec.Name = "cmbBolumSec";
            this.cmbBolumSec.Size = new System.Drawing.Size(180, 21);
            this.cmbBolumSec.TabIndex = 3;
            this.cmbBolumSec.Text = "Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölüm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fakülte";
            // 
            // cmbFakulteSec
            // 
            this.cmbFakulteSec.FormattingEnabled = true;
            this.cmbFakulteSec.Location = new System.Drawing.Point(78, 31);
            this.cmbFakulteSec.Name = "cmbFakulteSec";
            this.cmbFakulteSec.Size = new System.Drawing.Size(180, 21);
            this.cmbFakulteSec.TabIndex = 0;
            this.cmbFakulteSec.Text = "Seçiniz";
            this.cmbFakulteSec.SelectedIndexChanged += new System.EventHandler(this.cmbFakulteSec_SelectedIndexChanged);
            // 
            // frmBolumAnaBilimSayisalTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 470);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBolumAnaBilimSayisalTablosu";
            this.Text = "frmBolumAnaBilimSayisalTablosu";
            this.Load += new System.EventHandler(this.frmBolumAnaBilimSayisalTablosu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSayisalTablo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridSayisalTablo;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.ComboBox cmbBolumSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFakulteSec;
    }
}