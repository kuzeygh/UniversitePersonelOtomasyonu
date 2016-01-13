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
    public partial class frmKurumIciIdariGorev : Form
    {
        public frmKurumIciIdariGorev()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int personelID;
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
            {
                tblPersoneller p = db.tblPersoneller.FirstOrDefault(x => x.personel_ID == personelID);

                tblIdariGorev ig = db.tblIdariGorev.FirstOrDefault(x => x.personel_ID == p.personel_ID);
                ig.gorev = txtGorevler.Text;
                ig.baslangic_Tarihi = dtpBaslamaTarihi.Value;
                ig.bitis_Tarihi = dtpBitisTarihi.Value;
            }
        }

        private void frmKurumIciIdariGorev_Load(object sender, EventArgs e)
        {
            personelID = frmPersonelKayitDuzenleme.Personel.personel_ID;
        }
    }
}
