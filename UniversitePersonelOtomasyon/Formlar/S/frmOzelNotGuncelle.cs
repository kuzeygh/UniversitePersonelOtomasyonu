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
    public partial class frmOzelNotGuncelle : Form
    {
        public frmOzelNotGuncelle()
        {
            InitializeComponent();
        }

        private void frmOzelNotGuncelle_Load(object sender, EventArgs e)
        {
            List<int> IDler = OzelNotIslemleri.IDVer(frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            foreach(var i in IDler)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void btnOzelNotDegistir_Click(object sender, EventArgs e)
        {
            string ozelNot,Sonuc;
            ozelNot = textBox1.Text;

            OzelNotView ONV = new OzelNotView();
            ONV.OzelNot = ozelNot;

            Sonuc = OzelNotIslemleri.OzelNotGuncelle(ONV, frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString(), Convert.ToInt32(comboBox1.SelectedItem.ToString()));
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Ozel Not Güncellendi.");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Ozel Not Güncellenirken Hata Oluştu. Hata: " + Sonuc);
            }

        }
    }
}
