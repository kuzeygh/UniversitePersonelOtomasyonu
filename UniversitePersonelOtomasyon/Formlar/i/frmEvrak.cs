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
    public partial class frmEvrak : Form
    {
        public frmEvrak()
        {
            InitializeComponent();
        }
        int personelID;

        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
            {
                tblPersoneller p = db.tblPersoneller.FirstOrDefault(x => x.personel_ID == personelID);
                tblEvraklar evrak = db.tblEvraklar.FirstOrDefault(x => x.personel_ID == p.personel_ID);

                if (cbIsBasvuruFormu.Checked)
                    evrak.is_Basvuru_Formu = true;
                evrak.is_Basvuru_Formu = false;

                if (cbLisansBasvurusu.Checked)
                    evrak.lisans_Basvurusu = true;
                evrak.lisans_Basvurusu = false;

                if (cbNufusCuzdaniFotokopisi.Checked)
                    evrak.nufus_Cuzdan_Fotokopisi = true;
                evrak.nufus_Cuzdan_Fotokopisi = false;

                if (cbSaglikRaporu.Checked)
                    evrak.saglik_Raporu = true;
                evrak.saglik_Raporu = false;

                if (cbVesikalik.Checked)
                    evrak.vesikalik = true;
                evrak.vesikalik = false;
            }
        }

        private void frmEvrak_Load(object sender, EventArgs e)
        {
            personelID = frmPersonelKayitDuzenleme.Personel.personel_ID;
        }
    }
}
