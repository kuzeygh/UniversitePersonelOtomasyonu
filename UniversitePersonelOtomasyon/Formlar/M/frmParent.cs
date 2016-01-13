using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitePersonelOtomasyon.Formlar.M;
using UniversitePersonelOtomasyon.Formlar.S;

namespace UniversitePersonelOtomasyon.Formlar.M
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void frmParent_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmParent_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPersonelKayitDuzenleme.Personel_kullaniciAdı = null;
            Application.OpenForms[0].Controls["txtKullaniciAdi"].Text = "";
            Application.OpenForms[0].Controls["txtSifre"].Text = "";
            this.Opacity = 0;
            for (int i = 2; i < Application.OpenForms.Count; i++)
                Application.OpenForms[i].Close();
            MessageBox.Show("Başarıyla çıkış yapıldı.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.OpenForms[0].Show();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelKayitDuzenleme.formTuru = frmPersonelKayitDuzenleme.efromTuru.Duzenleme;
            frmPersonelKayitDuzenleme.Personel = new Models.DataModel.tblPersoneller() { personel_ID = -1 };
            Form frmKayit = new frmPersonelKayitDuzenleme();
            frmKayit.MdiParent = this;
            frmKayit.WindowState = FormWindowState.Maximized;
            frmKayit.Show();
        }

        private void aramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmArama = new frmPersonelArama();
            frmArama.MdiParent = this;
            frmArama.WindowState = FormWindowState.Maximized;
            frmArama.Show();
        }

        private void bölümBazındaSayısalTabloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmSayisalTablo = new frmBolumAnaBilimSayisalTablosu();
            frmSayisalTablo.MdiParent = this;
            frmSayisalTablo.WindowState = FormWindowState.Maximized;
            frmSayisalTablo.Show();
        }

        private void kullanıcıYönetimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmKullanici = new frmKullaniciYonetim();
            frmKullanici.MdiParent = this;
            frmKullanici.WindowState = FormWindowState.Maximized;
            frmKullanici.Show();
        }

        private void idariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BL.T.RaporIslem.İdariPersonelİsimListesiRaporuYazdir();

        }

        private void iştenAyrılanPersonellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form istenAyrilan = new frmIstenAyrilan();
            istenAyrilan.MdiParent = this;
            istenAyrilan.WindowState = FormWindowState.Maximized;
            istenAyrilan.Show();
        }
    }
}
