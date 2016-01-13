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
using UniversitePersonelOtomasyon.BL.S;
using UniversitePersonelOtomasyon.Formlar.M;

namespace UniversitePersonelOtomasyon
{
    public partial class frmOgrenimBilgileri : Form
    {
        public frmOgrenimBilgileri()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmOgrenimBilgileriEkleme OBE = new frmOgrenimBilgileriEkleme();
            OBE.Show();
        }

        private void frmOgrenimBilgileri_Load(object sender, EventArgs e)
        {
            string ogrenimSeviyesi;
            ogrenimSeviyesi = comboBox1.SelectedItem.ToString();

            List<tblEgitim> E = EgitimIslemleri.EgitimGetir(ogrenimSeviyesi,frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            DataTable dt = new DataTable();
            dt.Columns.Add("Egitim ID");
            dt.Columns.Add("Okul Adi");
            dt.Columns.Add("Giris Tarihi");
            dt.Columns.Add("Mezuniyet Tarihi");

            foreach (var item in E)
            {
                dt.Rows.Add(item.egitim_ID,item.okul_Adi,item.giris_Tarihi,item.mezuniyet_Tarihi);
            }
            dataGridEgitim.DataSource = dt;

            List<tblYabanciDil> YDil = EgitimIslemleri.YabanciDilGetir(frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Yabancı Dil ID");
            dt2.Columns.Add("Yabancı Dil");
            dt2.Columns.Add("Sınav Tarihi");
            dt2.Columns.Add("Puan");

            foreach(var item in YDil)
            {
                dt.Rows.Add(item.yabanciDil_ID, item.yabanci_Dil, item.sinav_Tarihi, item.puan);
            }
            dataGridYabanciDil.DataSource = dt2;
        }
    }
}
