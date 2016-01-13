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

namespace UniversitePersonelOtomasyon
{
    public partial class frmIzinBilgileri : Form
    {
        public frmIzinBilgileri()
        {
            InitializeComponent();
        }

        private void bntIzınEkle_Click(object sender, EventArgs e)
        {
            frmIzinEkle IE = new frmIzinEkle();
            IE.Show();
        }

        private void frmIzinBilgileri_Load(object sender, EventArgs e)
        {
            List<tblIzin> izin = IzinBilgileri.IzinleriGetir(frmPersonelKayitDuzenleme.Personel_kullaniciAdı.ToString());
            
            DataTable dt = new DataTable();
            dt.Columns.Add("İzin ID");
            dt.Columns.Add("İzin Türü");
            dt.Columns.Add("İzin Bilgisi");
            dt.Columns.Add("Baslangic Tarihi");
            dt.Columns.Add("Bitis Tarihi");

            foreach (var item in izin)
            {
                dt.Rows.Add(item.izin_ID,item.izin_Turu,item.izin_Bilgisi,item.baslangic_Tarihi,item.bitis_Tarihi);
            }
            dataGridIzın.DataSource = dt;
        }
    }
}
