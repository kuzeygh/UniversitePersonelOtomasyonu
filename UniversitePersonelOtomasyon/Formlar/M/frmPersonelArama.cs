using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitePersonelOtomasyon.BL.M;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Formlar.M;
namespace UniversitePersonelOtomasyon.Formlar.M
{
    public partial class frmPersonelArama : Form
    {
        public frmPersonelArama()
        {
            InitializeComponent();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            string Ad = txtAd.Text;
            if (Ad == "")
            {
                MessageBox.Show("Hata! Ad alanı boş geçilemez",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
            DataTable dt = MamiKatmanı.Search(Ad);
            if (Ad != null)
                dtgSearchResult.DataSource = dt;
            else
                MessageBox.Show("Kayıt bulunamadı",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dtgSearchResult.SelectedRows.Count>0)
            {
                int personelID = Convert.ToInt32(dtgSearchResult.SelectedRows[0].Cells["ID"]);
                tblPersoneller p = MamiKatmanı.PersonelDetails(personelID);
                string kullaniciAdi = MamiKatmanı.userName(personelID);
                frmPersonelKayitDuzenleme.Personel_kullaniciAdı = kullaniciAdi;
                frmPersonelKayitDuzenleme.formTuru = frmPersonelKayitDuzenleme.efromTuru.Duzenleme;
                Form frmDuzenle = new frmPersonelKayitDuzenleme();
                frmDuzenle.MdiParent = Application.OpenForms[1];
                frmDuzenle.WindowState = FormWindowState.Maximized;
                frmDuzenle.Show();
                this.Close(); 
            }else
                MessageBox.Show("Lütfen personel seçiniz..",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Warning);


        }
    }
}
