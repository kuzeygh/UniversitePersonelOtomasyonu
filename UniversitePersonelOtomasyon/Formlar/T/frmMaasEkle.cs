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
    public partial class frmMaasEkle : Form
    {
        public frmMaasEkle()
        {
            InitializeComponent();
        }

        private void frmMaasEkle_Load(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    foreach (var personel in db.tblPersoneller.ToList())
                    {
                        comboBox1.Items.Add(personel.personel_ID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaş bilgileri ekleme ekranında hata: " + ex.Message);
            }
        }
        bool kayitVarmi = false; // <--- ÖNEMLİ
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    foreach (var maas in db.tblMaas.ToList())
                    {
                        if (maas.personel_ID == (int?)comboBox1.SelectedItem)
                        {
                            kayitVarmi = true;
                            textBox1.Text = maas.maas.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaş bilgileri ekleme ekranında hata: " + ex.Message);
            }
        }

        private void btnMaasEkle_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PersonelOtomasyonDBEntities2())
                {
                    tblMaas m2;
                    if (kayitVarmi)
                    {
                        m2 = db.tblMaas.FirstOrDefault(x => x.personel_ID == Convert.ToInt32(comboBox1.SelectedItem));
                        db.tblMaas.Remove(m2);
                    }
                    db.tblMaas.Add(new tblMaas() { maas = Convert.ToInt32(textBox1.Text), personel_ID = Convert.ToInt32(comboBox1.SelectedItem) });
                    db.SaveChanges();
                    frmMaasBilgileri mb = new frmMaasBilgileri();
                    mb.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaş bilgileri ekleme ekranında hata: " + ex.Message);
            }
        }
    }
}
