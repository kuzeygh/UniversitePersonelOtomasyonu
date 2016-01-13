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
    public partial class frmNufusBilgileri : Form
    {

        public int personelID;
        private static PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2();

        public frmNufusBilgileri()
        {
            InitializeComponent();
        }

        private void frmNufusBilgileri_Load(object sender, EventArgs e)
        {
            personelID = frmPersonelKayitDuzenleme.Personel.personel_ID;
            if (personelID == 0)
                return;
            
            foreach (var il in db.tblIller)
            {
                cmbIl.Items.Add(il.nufusaKayitliOlduguIl);
            }

            tblPersoneller p = db.tblPersoneller.FirstOrDefault(x => x.personel_ID == personelID);
            
            tblNufusBilgiler nb = db.tblNufusBilgiler.FirstOrDefault(x => x.personel_ID == p.personel_ID);
            tblMadeniHali mh = db.tblMadeniHali.FirstOrDefault(x => x.madeniHali_ID == nb.madeniHali_ID);
            tblUyruk u = db.tblUyruk.FirstOrDefault(x => x.uyrugu_ID == nb.uyrugu_ID);
            tblIller i = db.tblIller.FirstOrDefault(x => x.nufusaKayitliOlduguIl_ID == nb.nufusaKayitliOlduguIl_ID);
            tblIlceler ilce = db.tblIlceler.FirstOrDefault(x => x.nufusaKayitliOlduguIlce_ID == nb.nufusaKayitliOlduguIlce_ID);
            tblVerilisNedeni vn = db.tblVerilisNedeni.FirstOrDefault(x => x.verilisNedeni_ID == nb.verilisNedeni_ID);
            

            txtNufusCuzdanNo.Text = nb.nufusCuzdanNo;
            txtTCKimlikNo.Text = nb.tcKimlikNo;
            txtBabaAdi.Text = nb.babaAdi;
            txtAnaAdi.Text = nb.anaAdi;
            txtDogumYeri.Text = nb.DogumYeri;
            dtpDogumTarihi.Value = Convert.ToDateTime(nb.dogumTarihi);
            cmbMedeniHali.SelectedItem = mh.madeniHali;
            txtUyrugu.Text = u.uyruk;

            cmbIl.SelectedItem = i.nufusaKayitliOlduguIl;
            cmbIlce.SelectedItem = ilce.nufusaKayitliOlduguIlce;
            txtMahKoy.Text = nb.mahKoy;
            txtCiltNo.Text = nb.ciltNo;
            txtAileSiraNo.Text = nb.aileSıraNo;
            txtSiraNo.Text = nb.sıraNo;
            txtVerildigiYer.Text = nb.verildigiYer;
            cmbVerilisNedeni.SelectedItem = vn.verilisNedeni;
        }

        private void cmbIl_SelectedIndexChanged(object sender, EventArgs e)
        {

            tblIller secilenIl = db.tblIller.FirstOrDefault(x => x.nufusaKayitliOlduguIl == cmbIl.SelectedItem);
            foreach (var ilce in db.tblIlceler)
            {
                cmbIlce.Items.Add(ilce.nufusaKayitliOlduguIlce);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tblPersoneller p = new tblPersoneller();
            
            tblNufusBilgiler nb = db.tblNufusBilgiler.FirstOrDefault(x => x.personel_ID == p.personel_ID);
            tblMadeniHali mh = db.tblMadeniHali.FirstOrDefault(x => x.madeniHali_ID == nb.madeniHali_ID);
            tblUyruk u = db.tblUyruk.FirstOrDefault(x => x.uyrugu_ID == nb.uyrugu_ID);
            tblIller i = db.tblIller.FirstOrDefault(x => x.nufusaKayitliOlduguIl_ID == nb.nufusaKayitliOlduguIl_ID);
            tblIlceler ilce = db.tblIlceler.FirstOrDefault(x => x.nufusaKayitliOlduguIlce_ID == nb.nufusaKayitliOlduguIlce_ID);
            tblVerilisNedeni vn = db.tblVerilisNedeni.FirstOrDefault(x => x.verilisNedeni_ID == nb.verilisNedeni_ID);

            nb.nufusCuzdanNo = txtNufusCuzdanNo.Text;
            nb.tcKimlikNo = txtTCKimlikNo.Text;
            nb.babaAdi = txtBabaAdi.Text;
            nb.anaAdi = txtAnaAdi.Text;
            nb.DogumYeri = txtDogumYeri.Text;
            nb.dogumTarihi = dtpDogumTarihi.Value;
            mh.madeniHali = cmbMedeniHali.SelectedItem.ToString();
            u.uyruk = txtUyrugu.Text;

            i.nufusaKayitliOlduguIl = cmbIl.SelectedItem.ToString();
            ilce.nufusaKayitliOlduguIlce = cmbIlce.SelectedItem.ToString();
            nb.mahKoy = txtMahKoy.Text;
            nb.ciltNo = txtCiltNo.Text;
            nb.aileSıraNo = txtAileSiraNo.Text;
            nb.sıraNo = txtSiraNo.Text;
            nb.verildigiYer = txtVerildigiYer.Text;
            vn.verilisNedeni = cmbVerilisNedeni.SelectedItem.ToString();
        }

    }
}
