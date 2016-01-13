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
using UniversitePersonelOtomasyon.Formlar.M;
namespace UniversitePersonelOtomasyon.Formlar.T
{
    public partial class frmİletisimBilgileri : Form
    {
        public frmİletisimBilgileri()
        {
            InitializeComponent();
        }

        private void frmİletisimBilgileri_Load(object sender, EventArgs e)
        {
            this.PersonelID = frmPersonelKayitDuzenleme.Personel.personel_ID;
            bool personelBulunduMu = false;
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    foreach (tblIller il in db.tblIller)
                    {
                        cmbİller.Items.Add(il.nufusaKayitliOlduguIl);
                        cmbIlceler.Enabled = true;
                    }

                    foreach (tblIletisim i in db.tblIletisim.ToList())
                    {
                        if (i.personel_ID == PersonelID)
                        {
                            personelBulunduMu = true;

                            txtAlan1.Text = i.ev_Tel.Substring(0, 3);
                            txtTel1.Text = i.ev_Tel.Substring(3);
                            txtEmail1.Text = i.e_Posta;
                            txtEvAdres.Text = i.ev_Adresi;
                            txtGSMAlan1.Text = i.cep_Tel.Substring(0, 3);
                            txtGSM1.Text = i.cep_Tel.Substring(3);
                            cmbİller.SelectedItem = db.tblIller.FirstOrDefault(x => x.nufusaKayitliOlduguIl_ID == i.il_ID).nufusaKayitliOlduguIl;
                            cmbIlceler.SelectedItem = db.tblIlceler.FirstOrDefault(x => x.nufusaKayitliOlduguIlce_ID == i.ilce_ID).nufusaKayitliOlduguIlce;

                        }
                    }

                    if (!personelBulunduMu)
                    {

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void cmbİller_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    tblIller seciliİl = db.tblIller.FirstOrDefault(x => x.nufusaKayitliOlduguIl == cmbİller.SelectedItem);
                    foreach (tblIlceler ilce in db.tblIlceler)
                    {
                        if (ilce.nufusaKayitliOlduguIl_ID == seciliİl.nufusaKayitliOlduguIl_ID)
                        {
                            cmbIlceler.Items.Add(ilce.nufusaKayitliOlduguIlce);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata: " + ex.Message);
            }

        }
        public int PersonelID;// <----- GEREKLİ
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    tblIletisim iletisim = new tblIletisim()
                    {
                        cep_Tel = txtGSMAlan1.Text + txtGSM1.Text,
                        e_Posta = txtEmail1.Text,
                        ev_Adresi = txtEvAdres.Text,
                        ev_Tel = txtAlan1.Text + txtTel1.Text,
                        personel_ID = PersonelID,
                        il_ID = db.tblIller.FirstOrDefault(x => x.nufusaKayitliOlduguIl == cmbİller.SelectedItem).nufusaKayitliOlduguIl_ID,
                        ilce_ID = db.tblIlceler.FirstOrDefault(x => x.nufusaKayitliOlduguIlce == cmbIlceler.SelectedItem).nufusaKayitliOlduguIlce_ID

                    };

                    db.tblIletisim.Add(iletisim);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İletisim bilgilerini eklerken hata:  " + ex.Message);
            }
        }
    }
}
