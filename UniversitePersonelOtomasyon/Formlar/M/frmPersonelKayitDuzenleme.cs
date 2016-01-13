using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Formlar.T;
using System.IO;
using UniversitePersonelOtomasyon.BL.M;
using UniversitePersonelOtomasyon.Formlar.i;
using UniversitePersonelOtomasyon.Formlar.S;

namespace UniversitePersonelOtomasyon.Formlar.M
{
    public partial class frmPersonelKayitDuzenleme : Form
    {
        public frmPersonelKayitDuzenleme()
        {
            InitializeComponent();
        }
        public enum efromTuru
        {
            Kayit,
            Duzenleme
        };
        public static efromTuru formTuru;
        public static tblPersoneller Personel;
        public static string Personel_kullaniciAdı;
        private void frmPersonelKayitDuzenleme_Load(object sender, EventArgs e)
        {
            
            if(formTuru == efromTuru.Kayit)
            {
                Personel = new tblPersoneller();
                Form genelBilgiler = new frmGenelBilgiler();
                genelBilgiler.TopLevel = false;

                Form iletisim = new frmİletisimBilgileri();
                iletisim.TopLevel = false;

                Form nufus = new frmNufusBilgileri();
                nufus.TopLevel = false;

                TabPage tbGenelBilgiler = new TabPage();
                tbGenelBilgiler.Text = "Genel Bilgiler";
                TabPage tbNufusBilgileri = new TabPage();
                tbNufusBilgileri.Text = "Nüfus Bilgileri";
                TabPage tbIletisimBilgileri = new TabPage();
                tbIletisimBilgileri.Text = "Iletisim";

                tabcEkranlar.TabPages.Add(tbGenelBilgiler);
                tabcEkranlar.TabPages.Add(tbNufusBilgileri);
                tabcEkranlar.TabPages.Add(tbIletisimBilgileri);

                tbGenelBilgiler.Controls.Add(genelBilgiler);
                tbIletisimBilgileri.Controls.Add(iletisim);
                tbNufusBilgileri.Controls.Add(nufus);

                iletisim.WindowState = FormWindowState.Maximized;
                genelBilgiler.WindowState = FormWindowState.Maximized;
                nufus.WindowState = FormWindowState.Maximized;

                nufus.Show();
                iletisim.Show();
                genelBilgiler.Show();
            }
            else
            {
                Form genelBilgiler = new frmGenelBilgiler();
                Form iletisimBilgileri = new frmİletisimBilgileri();
                Form MaasBilgileri = new frmMaasBilgileri();
                Form ogrenimBilgileri = new frmOgrenimBilgileri();
                Form saglikBilgileri = new frmSaglikBilgileri();
                Form izinBilgileri = new frmIzinBilgileri();
                Form ozelNot = new frmOzelNot();
                Form BilimselFaaliyetler = new frmBilimselFaaliyetler();
                Form cocukBilgileri = new frmCocukBilgileri();
                Form evrak = new frmEvrak();
                Form idari = new frmIdariGorevler();
                Form nufus = new frmNufusBilgileri();
                Form verdigiDersler = new frmVerdigiDersler();
                Form ceza = new frmCeza();
                //deneyim
                //görev bilg
                ceza.TopLevel = false;
                verdigiDersler.TopLevel = false;
                nufus.TopLevel = false;
                idari.TopLevel = false;
                evrak.TopLevel = false;
                cocukBilgileri.TopLevel = false;
                genelBilgiler.TopLevel = false;
                iletisimBilgileri.TopLevel = false;
                MaasBilgileri.TopLevel = false;
                ogrenimBilgileri.TopLevel = false;
                saglikBilgileri.TopLevel = false;
                BilimselFaaliyetler.TopLevel = false;
                izinBilgileri.TopLevel = false;
                ozelNot.TopLevel = false;

                TabPage tbGenelBilgiler = new TabPage();
                TabPage tbNufusBilgileri = new TabPage();
                TabPage tbIletisimBilgileri = new TabPage();
                TabPage tbogrenimBilgileri = new TabPage();
                TabPage tbDersYuku = new TabPage();
                TabPage tbsaglikBilgileri = new TabPage();
                TabPage tbAileCocuk = new TabPage();
                TabPage tbIzınBilgileri = new TabPage();
                TabPage tbCezaBilgileri = new TabPage();
                TabPage tbIdariGorevler = new TabPage();
                TabPage tbMaasBilgileri = new TabPage();
                TabPage tbFaaliyetler = new TabPage();
                TabPage tbGorevBilgi = new TabPage();
                TabPage tbDeneyim = new TabPage();
                TabPage tbEvraklar = new TabPage();
                TabPage tbOzelNot = new TabPage();
                TabPage Atamalar = new TabPage();


                tbGenelBilgiler.Text = "Genel Bilgiler";
                tbNufusBilgileri.Text = "Nüfus Bilgileri";
                tbIletisimBilgileri.Text = "İletisim";
                tbogrenimBilgileri.Text = "Öğrenim Bilgileri";
                tbsaglikBilgileri.Text = "Sağlık Bilgileri";
                tbAileCocuk.Text = "Aile - Çocuk";
                tbCezaBilgileri.Text = "Ceza Bilgileri";
                tbDeneyim.Text = "Deneyim";
                tbDersYuku.Text = "Ders yükü";
                tbEvraklar.Text = "Evraklar";
                tbFaaliyetler.Text = "Faaliyetler";
                tbGorevBilgi.Text = "Görev Bilg.";
                tbIdariGorevler.Text = "İdari Görevler";
                tbIzınBilgileri.Text = "İzin Bilgileri";
                tbMaasBilgileri.Text = "Mayiş Bilgileri";
                tbOzelNot.Text = "Özel Not";

                tabcEkranlar.TabPages.Add(tbGenelBilgiler);
                tabcEkranlar.TabPages.Add(tbNufusBilgileri);
                tabcEkranlar.TabPages.Add(tbIletisimBilgileri);
                tabcEkranlar.TabPages.Add(tbogrenimBilgileri);
                tabcEkranlar.TabPages.Add(tbsaglikBilgileri);
                tabcEkranlar.TabPages.Add(tbAileCocuk);
                tabcEkranlar.TabPages.Add(tbCezaBilgileri);
                tabcEkranlar.TabPages.Add(tbDeneyim);
                tabcEkranlar.TabPages.Add(tbDersYuku);
                tabcEkranlar.TabPages.Add(tbEvraklar);
                tabcEkranlar.TabPages.Add(tbFaaliyetler);
                tabcEkranlar.TabPages.Add(tbGorevBilgi);
                tabcEkranlar.TabPages.Add(tbIdariGorevler);
                tabcEkranlar.TabPages.Add(tbIzınBilgileri);
                tabcEkranlar.TabPages.Add(tbMaasBilgileri);
                tabcEkranlar.TabPages.Add(tbOzelNot);

                tbGenelBilgiler.Controls.Add(genelBilgiler);
                tbogrenimBilgileri.Controls.Add(ogrenimBilgileri);
                tbsaglikBilgileri.Controls.Add(saglikBilgileri);
                tbIletisimBilgileri.Controls.Add(iletisimBilgileri);
                tbMaasBilgileri.Controls.Add(MaasBilgileri);
                tbIzınBilgileri.Controls.Add(izinBilgileri);
                tbOzelNot.Controls.Add(ozelNot);
                tbFaaliyetler.Controls.Add(BilimselFaaliyetler);
                tbNufusBilgileri.Controls.Add(nufus);
                tbIdariGorevler.Controls.Add(idari);
                tbEvraklar.Controls.Add(evrak);
                tbAileCocuk.Controls.Add(cocukBilgileri);
                tbDersYuku.Controls.Add(verdigiDersler);
                tbCezaBilgileri.Controls.Add(ceza);

                ceza.WindowState = FormWindowState.Maximized;
                verdigiDersler.WindowState = FormWindowState.Maximized;
                BilimselFaaliyetler.WindowState = FormWindowState.Maximized;
                genelBilgiler.WindowState = FormWindowState.Maximized;
                ogrenimBilgileri.WindowState = FormWindowState.Maximized;
                saglikBilgileri.WindowState = FormWindowState.Maximized;
                MaasBilgileri.WindowState = FormWindowState.Maximized;
                iletisimBilgileri.WindowState = FormWindowState.Maximized;
                izinBilgileri.WindowState = FormWindowState.Maximized;
                ozelNot.WindowState = FormWindowState.Maximized;

                ceza.Show();
                verdigiDersler.Show();
                genelBilgiler.Show();
                nufus.Show();
                idari.Show();
                evrak.Show();
                cocukBilgileri.Show();
                genelBilgiler.Show();
                iletisimBilgileri.Show();
                MaasBilgileri.Show();
                ogrenimBilgileri.Show();
                saglikBilgileri.Show();
                BilimselFaaliyetler.Show();
                izinBilgileri.Show();
                ozelNot.Show();

                //picImage.Image = Bitmap.FromFile(Personel.personel_Resim);

            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

            
            if (MamiKatmanı.Save(Personel))
            {
                for (int i = 0; i < tabcEkranlar.TabPages.Count; i++)
                {
                    ((Button)((tabcEkranlar.TabPages[0].Controls[0]).Controls["btnKaydet"])).PerformClick();
                }
                MessageBox.Show("Kaydetme başarılı.", this.Text);
            }
            else
                MessageBox.Show("Kaydetme başarısız.", this.Text);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //File.Move(openFileDialog1.FileName,sDialog.FileName);
        private void btnIstenCikar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("İşten çıkarmak istediğinize emin misiniz?",this.Text,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button3);
            if(dr == DialogResult.Yes)
            {
                if (MamiKatmanı.istenCikar(Personel))
                    MessageBox.Show("İşten çıkarma başarılı",this.Text);
                else
                    MessageBox.Show("İşten çıkarma başarısız.");
            }
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string Path = openFileDialog1.FileName;
            if (File.Exists( @"..\..\Resources\Personel\" + openFileDialog1.SafeFileName) == true)
            {
                MessageBox.Show("Aynı resimden bulunmaktadır.",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            File.Copy(Path, @"..\..\Resources\Personel\" + openFileDialog1.SafeFileName);
            Personel.personel_Resim = @"..\..\Resources\Personel\" + openFileDialog1.SafeFileName;
            picImage.Image = Bitmap.FromFile(@"..\..\Resources\Personel\" + openFileDialog1.SafeFileName);
        }
    }
}
