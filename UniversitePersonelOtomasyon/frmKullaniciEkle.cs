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
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon
{
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnKullaniciEkleme_Click(object sender, EventArgs e)
        {
            string KAd, Sifre,Sonuc;
            int Id;
            KAd = txtKullaniciAdi.Text;
            Sifre = txtSifre.Text;
            if (chckFakulteSekreteri.Checked)
            {
                Id = 1;
            }
            else
            {
                Id = 0;
            }

            KullaniciView K = new KullaniciView() {
                KAd = KAd,
                Sifre = Sifre,
                Type = Id
            };
            Sonuc = KullaniciIslemleri.KullaniciEkle(K);
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Kullanici Eklendi.");
            }
            else
            {
                MessageBox.Show(Sonuc);
            }            
        }
    }
}
