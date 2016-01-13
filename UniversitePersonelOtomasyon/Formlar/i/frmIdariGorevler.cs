using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitePersonelOtomasyon.Formlar.M;
using UniversitePersonelOtomasyon.Models.DataModel;

namespace UniversitePersonelOtomasyon.Formlar.i
{
    public partial class frmIdariGorevler : Form
    {
        public frmIdariGorevler()
        {
            InitializeComponent();
        }

        private void btnGorevEkle_Click(object sender, EventArgs e)
        {
            frmKurumIciIdariGorev kig = new frmKurumIciIdariGorev();
            kig.Show();
        }
        public int personelID;
        private static PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2();

        private void frmIdariGorevler_Load(object sender, EventArgs e)
        {
            personelID = frmPersonelKayitDuzenleme.Personel.personel_ID;
            DataTable dt = new DataTable();
            dt.Columns.Add("Görev Adı");
            dt.Columns.Add("Başlama Tarihi");
            dt.Columns.Add("Bitiş Tarihi");

            foreach (tblIdariGorev ig in db.tblIdariGorev.ToList())
            {
                dt.Rows.Add(ig.gorev);
                dt.Rows.Add(ig.baslangic_Tarihi);
                dt.Rows.Add(ig.bitis_Tarihi);
            }

            dgvGorev.DataSource = dt;
        }
    }
}
