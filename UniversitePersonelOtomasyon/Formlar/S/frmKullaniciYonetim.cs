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

namespace UniversitePersonelOtomasyon
{
    public partial class frmKullaniciYonetim : Form
    {
        public frmKullaniciYonetim()
        {
            InitializeComponent();
        }

        private void frmKullaniciYonetim_Load(object sender, EventArgs e)
        {
            List<tblKullanicilar> K = KullaniciIslemleri.KullaniciGetir();
            DataTable dt = new DataTable();
            dt.Columns.Add("Kullanıcı ID");
            dt.Columns.Add("Kullanıcı Adı");
            dt.Columns.Add("Kullanıcı Sifre");

            foreach (var item in K)
            {
                dt.Rows.Add(item.kullanici_ID,item.kullanici_Ad,item.kullanici_Sifre);
            }

            dataGridKullanicilar.DataSource = dt;
        }
    }
}
