using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitePersonelOtomasyon.Models.ViewModel.S;
using UniversitePersonelOtomasyon.BL.S;
using UniversitePersonelOtomasyon.Formlar.M;

namespace UniversitePersonelOtomasyon
{
    public partial class frmOgrenimBilgileriEkleme : Form
    {
        public frmOgrenimBilgileriEkleme()
        {
            InitializeComponent();
        }

        private void dateGiris_ValueChanged(object sender, EventArgs e)
        {
           if(dateGiris.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Baslangic Tarihi Güncel Tarihten Sonra Olamaz");
                dateGiris.Value = DateTime.Now.Date;
            }
        }

        private void dateMezuniyet_ValueChanged(object sender, EventArgs e)
        {
            if(dateMezuniyet.Value.Date < dateGiris.Value.Date)
            {
                MessageBox.Show("Mezuniyet Tarihi Giris Tarihinden Önce Olamaz");
                dateMezuniyet.Value = dateGiris.Value.Date.AddDays(1);
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string okulAdi, bolumAdi, ogrenimSeviyesi, Sonuc;
            DateTime baslangic, mezuniyet;

            okulAdi = txtOkulAdi.Text;
            bolumAdi = txtBolum.Text;
            ogrenimSeviyesi = cmbOgrenimSeviyesi.SelectedItem.ToString();
            baslangic = dateGiris.Value.Date;
            mezuniyet = dateMezuniyet.Value.Date;

            EgitimView EV = new EgitimView();
            EV.OkulAdi = okulAdi;
            EV.BolumAdi = bolumAdi;
            EV.Baslangic = baslangic;
            EV.Mezuniyet = mezuniyet;
            EV.OgrenimSeviyesi = ogrenimSeviyesi;

            Sonuc = EgitimIslemleri.OgrenimBilgileriEkle(EV, frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Eğitim Bilgileri Eklendi.");
            }
            else
            {
                MessageBox.Show("Eğitim Bilgilerini Eklerken Hata Oluştu. Hata: " + Sonuc);
            }
        }

        private void dateSinav_ValueChanged(object sender, EventArgs e)
        {
            if(dateSinav.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Sinav Tarihi Güncel Tarihten Sonra Olamaz");
                dateSinav.Value = DateTime.Now.Date;
            }
        }

        private void btnYabanciDilEkle_Click(object sender, EventArgs e)
        {
            string yabanciDil,Sonuc;
            int puan;
            DateTime sinavTarihi;

            yabanciDil = txtYabanciDil.Text;
            puan = Convert.ToInt32(txtPuan.Text);
            sinavTarihi = dateSinav.Value.Date;

            YabanciDilView YDV = new YabanciDilView();
            YDV.YabanciDil = yabanciDil;
            YDV.SinavTarihi = sinavTarihi;
            YDV.Puan = puan;

            Sonuc = EgitimIslemleri.YabanciDilEkle(YDV, frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Yabancı Dil Eklendi");
            }
            else
            {
                MessageBox.Show("Yabancı Dil Eklerken Hata Oluştu. Hata: " + Sonuc);
            }
        }
    }
}
