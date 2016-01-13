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
    public partial class frmOzelNotEkle : Form
    {
        public frmOzelNotEkle()
        {
            InitializeComponent();
        }

        private void btnOzelNotKayit_Click(object sender, EventArgs e)
        {
            string ozelNot, Sonuc;
            ozelNot = txtOzelNotSayfa.Text;
            OzelNotView ONV = new OzelNotView();
            ONV.OzelNot = ozelNot;

            Sonuc = OzelNotIslemleri.OzelNotEkle(ONV, frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Ozel Not Eklendi.");
            }
            else
            {
                MessageBox.Show("Ozel Not Eklerken Hata Oluştu.Hata : " + Sonuc);
            }
        }
    }
}
