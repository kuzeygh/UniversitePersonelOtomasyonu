namespace UniversitePersonelOtomasyon.Formlar.i
{
    partial class frmCocukBilgileri
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
            this.grpCocuk = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvCocuklar = new System.Windows.Forms.DataGridView();
            this.AdiSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cinsiyeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OkuduguOkul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCocukSayisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpCocuk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCocuklar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCocuk
            // 
            this.grpCocuk.Controls.Add(this.textBox1);
            this.grpCocuk.Controls.Add(this.dgvCocuklar);
            this.grpCocuk.Controls.Add(this.txtCocukSayisi);
            this.grpCocuk.Controls.Add(this.label1);
            this.grpCocuk.Controls.Add(this.label5);
            this.grpCocuk.Location = new System.Drawing.Point(12, 12);
            this.grpCocuk.Name = "grpCocuk";
            this.grpCocuk.Size = new System.Drawing.Size(683, 367);
            this.grpCocuk.TabIndex = 0;
            this.grpCocuk.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "sayı değişince form açılacak";
            // 
            // dgvCocuklar
            // 
            this.dgvCocuklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCocuklar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdiSoyadi,
            this.Cinsiyeti,
            this.DogumTarihi,
            this.OkuduguOkul});
            this.dgvCocuklar.Location = new System.Drawing.Point(21, 103);
            this.dgvCocuklar.Name = "dgvCocuklar";
            this.dgvCocuklar.Size = new System.Drawing.Size(640, 248);
            this.dgvCocuklar.TabIndex = 14;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdiSoyadi.HeaderText = "Adı Soyadı";
            this.AdiSoyadi.Name = "AdiSoyadi";
            // 
            // Cinsiyeti
            // 
            this.Cinsiyeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cinsiyeti.HeaderText = "Cinsiyeti";
            this.Cinsiyeti.Name = "Cinsiyeti";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DogumTarihi.HeaderText = "Doğum Tarihi";
            this.DogumTarihi.Name = "DogumTarihi";
            // 
            // OkuduguOkul
            // 
            this.OkuduguOkul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OkuduguOkul.HeaderText = "Okuduğu Okul";
            this.OkuduguOkul.Name = "OkuduguOkul";
            // 
            // txtCocukSayisi
            // 
            this.txtCocukSayisi.Location = new System.Drawing.Point(161, 77);
            this.txtCocukSayisi.Name = "txtCocukSayisi";
            this.txtCocukSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtCocukSayisi.TabIndex = 13;
            this.txtCocukSayisi.Text = "0";
            this.txtCocukSayisi.TextChanged += new System.EventHandler(this.txtCocukSayisi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Çocukların";
            // 
            // frmCocukBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 391);
            this.Controls.Add(this.grpCocuk);
            this.Name = "frmCocukBilgileri";
            this.Text = "Çocuk Bilgileri";
            this.grpCocuk.ResumeLayout(false);
            this.grpCocuk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCocuklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCocuk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCocukSayisi;
        private System.Windows.Forms.DataGridView dgvCocuklar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdiSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cinsiyeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn DogumTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OkuduguOkul;
    }
}