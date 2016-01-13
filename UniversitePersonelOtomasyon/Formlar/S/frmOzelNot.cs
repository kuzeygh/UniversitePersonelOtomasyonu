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
using UniversitePersonelOtomasyon.Models.ViewModel.S;
using UniversitePersonelOtomasyon.Formlar.M;
using UniversitePersonelOtomasyon.BL.S;


namespace UniversitePersonelOtomasyon
{
    public partial class frmOzelNot : Form
    {
        public frmOzelNot()
        {
            InitializeComponent();
        }

        private void btnOzelNotEkle_Click(object sender, EventArgs e)
        {
            frmOzelNotEkle ONE = new frmOzelNotEkle();
            ONE.Show();
        }

        private void bntOzelNotGuncelle_Click(object sender, EventArgs e)
        {
            frmOzelNotGuncelle ONG = new frmOzelNotGuncelle();
            ONG.Show();
        }

        private void frmOzelNot_Load(object sender, EventArgs e)
        {          
            List<tblOzelNot> ON = OzelNotIslemleri.OzelNotGetir(frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            DataTable dt = new DataTable();
            dt.Columns.Add("Ozet Not ID");
            dt.Columns.Add("Ozel Not");

            foreach(var item in ON)
            {
                dt.Rows.Add(item.ozelNot_ID, item.ozel_Not);
            }

            dataGridOzelNot.DataSource = dt;
        }
    }
}
