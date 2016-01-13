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

namespace UniversitePersonelOtomasyon.Formlar.S
{
    public partial class frmCezaEkle : Form
    {
        public frmCezaEkle()
        {
            InitializeComponent();
        }

        private void dateBitis_ValueChanged(object sender, EventArgs e)
        {
            if(dateBaslangic.Value.Date > dateBitis.Value.Date)
            {
                MessageBox.Show("Bitis Tarihi Başlangıç Tarihinden Büyük Olamaz");
                dateBitis.Value = dateBaslangic.Value.Date.AddDays(1);
            }
        }

        private void btnCezaEkle_Click(object sender, EventArgs e)
        {
            string ceza,Sonuc;
            DateTime bas, bit;
            int gun,Id;

            ceza = txtCeza.Text;
            gun = Convert.ToInt32(txtGunSayisi.Text);
            bas = dateBaslangic.Value.Date;
            bit = dateBitis.Value.Date;
            Id = Convert.ToInt32(cmbPersonelId.SelectedItem.ToString());

            CezaView CV = new CezaView();
            CV.Ceza = ceza;
            CV.CezaGunSayisi = gun;
            CV.Baslangic = bas;
            CV.Bitis = bit;
            CV.PersonelId = Id;

            Sonuc = CezaIslemleri.CezaEkle(CV);
            if(Sonuc == "Yes")
            {
                MessageBox.Show("Ceza Eklendi");
            }
            else
            {
                MessageBox.Show("Ceza Eklerken Hata Oluştu. Hata: " + Sonuc);
            }
        }

        private void frmCezaEkle_Load(object sender, EventArgs e)
        {
            List<int> list = CezaIslemleri.IDGetir();
            foreach(var i in list)
            {
                cmbPersonelId.Items.Add(i);
            }
        }
    }
}
