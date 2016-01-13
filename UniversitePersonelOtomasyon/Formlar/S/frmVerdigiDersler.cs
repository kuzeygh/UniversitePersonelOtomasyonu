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

namespace UniversitePersonelOtomasyon.Formlar.S
{
    public partial class frmVerdigiDersler : Form
    {
        public frmVerdigiDersler()
        {
            InitializeComponent();
        }

        private void frmVerdigiDersler_Load(object sender, EventArgs e)
        {
            List<tblVerdigiDersler> VD = VerdigiDersler.DersGetir(frmGiris.Kullanici.ToString());
            DataTable dt = new DataTable();
            dt.Columns.Add("Ders ID");
            dt.Columns.Add("Ders");
            dt.Columns.Add("Başlangıç Saat");
            dt.Columns.Add("Bitiş Saat");

            foreach(var item in VD)
            {
                dt.Rows.Add(item.ders_ID, item.ders, item.ders_Baslangic_Saat, item.ders_Bitis_Saat);
            }
            dataGridDersler.DataSource = dt;
        }
    }
}
