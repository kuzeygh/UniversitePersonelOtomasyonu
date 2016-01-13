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
using UniversitePersonelOtomasyon.Formlar.M;
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon.Formlar.S
{
    public partial class frmVerdigiDerslerEkle : Form
    {
        public frmVerdigiDerslerEkle()
        {
            InitializeComponent();
        }

        private void frmVerdigiDerslerEkle_Load(object sender, EventArgs e)
        {
            List<int> Id = VerdigiDersler.SinifIdGetir();
            foreach(var i in Id)
            {
                cmbSinif.Items.Add(i);
            }
        }

        private void btnVerdigiDersEkle_Click(object sender, EventArgs e)
        {
            string ders, bas, bit, dersGunu, sinif, Sonuc;

            ders = txtDers.Text;
            bas = txtBaslangicSaat.Text;
            bit = txtBitisSaat.Text;
            dersGunu = cmbDersGunu.SelectedItem.ToString();
            sinif = cmbSinif.SelectedItem.ToString();

            DersView DV = new DersView();
            DV.Ders = ders;
            DV.BaslangicSaat = bas;
            DV.BitisSaat = bit;
            DV.DersGunu = dersGunu;
            DV.SinifId = Convert.ToInt32(sinif);

            Sonuc = VerdigiDersler.DersEkle(DV, frmGiris.Kullanici.ToString());
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Ders Eklendi.");
            }
            else
            {
                MessageBox.Show("Ders Eklerken Hata Oluştu. Hata: " + Sonuc);
            }
        }
    }
}
