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
namespace UniversitePersonelOtomasyon.Formlar.T
{
    public partial class frmSaglikBilgileri : Form
    {
        public frmSaglikBilgileri()
        {
            InitializeComponent();
        }
        public int PersonelID;// <----- GEREKLİ
        bool kayitVarMi = false;
        private void frmSaglikBilgileri_Load(object sender, EventArgs e)
        {

            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    foreach (tblSaglik s in db.tblSaglik.ToList())
                    {
                        if (s.personel_ID == PersonelID)
                        {
                            kayitVarMi = true;
                        }
                    }
                    if (kayitVarMi)
                    {
                        tblSaglik s = db.tblSaglik.FirstOrDefault(x => x.personel_ID == PersonelID);
                        txtAciklama.Text = s.aciklama;
                        txtDerece.Text = (s.sakatlikDerecesi).ToString();
                        if (s.sakatlikVarMı == true)
                        {
                            rdoEvet.Checked = true;
                            rdoHayir.Checked = false;
                        }
                        else
                        {
                            rdoEvet.Checked = false;
                            rdoHayir.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sağlık bilgileri ekranında hata: " + ex.Message);
            }
        }

        private void tbnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    tblSaglik s = new tblSaglik();
                    s.sakatlikVarMı = rdoEvet.Checked == true ? true : false;
                    if (s.sakatlikVarMı == true)
                    {
                        s.sakatlikDerecesi = Convert.ToInt32(txtDerece.Text);
                        if (s.sakatlikDerecesi < 0 || s.sakatlikDerecesi > 100)
                        {
                            MessageBox.Show("Sağlık bilgileri ekranında sakatlık derecesi 0-100 aralığında değil. Varsayılan değer atandı.");
                            s.sakatlikDerecesi = 20;
                        }
                    }
                    s.aciklama = txtAciklama.Text;
                    s.personel_ID = PersonelID;
                    if (kayitVarMi)
                    {
                        tblSaglik s2 = db.tblSaglik.FirstOrDefault(x => x.personel_ID == PersonelID);
                        s.saglik_ID = s2.saglik_ID;
                        db.tblSaglik.Remove(s2);
                    }
                    db.tblSaglik.Add(s);

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Sağlık bilgileri ekranında hata: " + ex.Message);
            }
        }


    }
}
