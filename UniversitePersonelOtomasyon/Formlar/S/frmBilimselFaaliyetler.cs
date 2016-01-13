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
using UniversitePersonelOtomasyon.Formlar.M;

namespace UniversitePersonelOtomasyon
{
    public partial class frmBilimselFaaliyetler : Form
    {
        public frmBilimselFaaliyetler()
        {
            InitializeComponent();
        }

        private void btnFaaliyetEkle_Click(object sender, EventArgs e)
        {
            frmBilimselFaaliyetEkle BFE = new frmBilimselFaaliyetEkle();
            BFE.Show();
        }

        private void frmBilimselFaaliyetler_Load(object sender, EventArgs e)
        {
            List<tblFaaliyet> FA = BilimselFaaliyet.FaaliyetGetir(frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());

            DataTable dt = new DataTable();
            dt.Columns.Add("Faaliyet ID");
            dt.Columns.Add("Yayin Türü");
            dt.Columns.Add("Yayin Tarihi");
            dt.Columns.Add("Puan");
                
            foreach (var item in FA)
            {
                dt.Rows.Add(item.faaliyet_ID, item.yayin_Turu, item.yayin_Tarihi, item.puan);
            }
            dataGridFaaliyetler.DataSource = dt;
        }
    }
}
