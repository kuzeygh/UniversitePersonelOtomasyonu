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
    public partial class frmMaasBilgileri : Form
    {
        public frmMaasBilgileri()
        {
            InitializeComponent();
        }

        private void frmMaasBilgileri_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    //personelId, Ad + Soyad, Unvan, işe giriş tarihi, maaş
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Personel ID");
                    dt.Columns.Add("Ad - Soyad ");
                    dt.Columns.Add("Ünvan");
                    dt.Columns.Add("Giriş tarihi");
                    dt.Columns.Add("Maaş");

                    foreach (tblMaas m in db.tblMaas.ToList())
                    {
                        tblPersoneller personel = db.tblPersoneller.FirstOrDefault(x => x.personel_ID == m.personel_ID);
                        decimal? maas = db.tblMaas.FirstOrDefault(x => x.personel_ID == personel.kullanici_ID).maas;
                        string unvan = db.tblUnvan.FirstOrDefault(x => x.unvan_ID == personel.unvan_ID).unvan;
                        dt.Rows.Add(personel.personel_ID, personel.personel_Ad+personel.personel_Soyad, unvan, personel.personel_GirisTarihi.Value.ToShortDateString(), maas + "₺" );
                    }
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaş bilgileri ekranında hata: " + ex.Message);
            }
        }

        private void tbnTanimla_Click(object sender, EventArgs e)
        {
            try
            {
                frmMaasEkle mEkle = new frmMaasEkle();
                mEkle.Show();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaş bilgileri ekranında hata: " + ex.Message);
            }
        }
    }
}
