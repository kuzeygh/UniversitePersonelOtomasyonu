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
    public partial class frmIzinEkle : Form
    {
        public frmIzinEkle()
        {
            InitializeComponent();
        }

        private void btnIzınEkle_Click(object sender, EventArgs e)
        {
            string izinTuru,izinBilgisi,Sonuc;
            DateTime baslangic, bitis;

            izinTuru = cmbIzinTuru.SelectedItem.ToString();
            izinBilgisi = txtIzinBilgisi.Text;
            baslangic = dateIzinBaslangic.Value.Date;
            bitis = dateIzinBitis.Value.Date;

            IzinView izin = new IzinView();
            izin.IzinTuru = izinTuru;
            izin.Baslangic = baslangic;
            izin.Bitis = bitis;
            izin.IzinBilgisi = izinBilgisi;

            Sonuc = IzinBilgileri.IzınEkle(izin, frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            if(Sonuc == "Yes")
            {
                MessageBox.Show("İzin Eklendi.");
            }
            else
            {
                MessageBox.Show("İzin Eklerken Hata Oluştu. Hata: " + Sonuc);
            }

        }

        private void dateIzinBaslangic_ValueChanged(object sender, EventArgs e)
        {
            if(dateIzinBaslangic.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Güncel Tarihten Önceki Tarih Seçilemez.");
                dateIzinBaslangic.Value = DateTime.Now.Date;
            }
        }

        private void dateIzinBitis_ValueChanged(object sender, EventArgs e)
        {
            if(dateIzinBitis.Value.Date < dateIzinBaslangic.Value.Date)
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden Önce Olamaz.");
                dateIzinBitis.Value = dateIzinBaslangic.Value.Date.AddDays(1);
            }
        }
    }
}
