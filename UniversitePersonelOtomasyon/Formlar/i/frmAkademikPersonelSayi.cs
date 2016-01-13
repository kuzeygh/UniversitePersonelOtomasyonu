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
    public partial class frmAkademikPersonelSayi : Form
    {
        public frmAkademikPersonelSayi()
        {
            InitializeComponent();
        }
        private static PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2();
        public int personelID;

        private void frmAkademikPersonelSayi_Load(object sender, EventArgs e)
        {
            personelID = frmPersonelKayitDuzenleme.Personel.personel_ID;
            tblPersoneller p = db.tblPersoneller.FirstOrDefault(x => x.personel_ID == personelID);
            tblFakülte f = db.tblFakülte.FirstOrDefault(x => x.fakulte_ID == p.fakulte_ID);

            DataTable dt = new DataTable();
            dt.Columns.Add("Fakülte");
            dt.Columns.Add("Profesör");
            dt.Columns.Add("Doçent");
            dt.Columns.Add("Yrd.Doç");
            dt.Columns.Add("Öğr.Gör");
            dt.Columns.Add("Uzman");
            dt.Columns.Add("Okutman");
            dt.Columns.Add("Ar.Gör");
            dt.Columns.Add("Çevirici");
            dt.Columns.Add("Eğ.Öğ.Pl");
            dt.Columns.Add("Toplam");

            foreach (tblUnvan u in db.tblUnvan.ToList())
            {


            }
        }
    }
}
