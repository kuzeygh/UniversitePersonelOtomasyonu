using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitePersonelOtomasyon.BL.S;
using UniversitePersonelOtomasyon.Models.ViewModel.S;
using UniversitePersonelOtomasyon.Formlar.M;

namespace UniversitePersonelOtomasyon
{
    public partial class frmBilimselFaaliyetEkle : Form
    {
        public frmBilimselFaaliyetEkle()
        {
            InitializeComponent();
        }

        private void dateYayinTarihi_ValueChanged(object sender, EventArgs e)
        {
            if(dateYayinTarihi.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Güncel Tarihten Sonra Tarih Seçemezsin.");
                dateYayinTarihi.Value = DateTime.Now.Date;
            }
        }

        private void btnFaaliyetEkleme_Click(object sender, EventArgs e)
        {
            string yayinTuru, adi,Sonuc;
            int puan;
            DateTime yayinTarihi;

            yayinTuru = txtYayinTuru.Text;
            adi = txtYayinAdi.Text;
            puan = Convert.ToInt32(txtPuan.Text);

            yayinTarihi = dateYayinTarihi.Value.Date;

            BilimselFaaliyetView BFV = new BilimselFaaliyetView()
            {
                YayinTuru = yayinTuru,
                Adi = adi,
                YayinTarihi = yayinTarihi,
                Puan = puan
            };


            Sonuc = BilimselFaaliyet.FaaliyetEkle(BFV, frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Faaliyet Eklendi.");
            }
            else
            {
                MessageBox.Show("Faaliyet Eklerken Hata Oluştu. Hata: " + Sonuc);
            }

        }
    }
}
