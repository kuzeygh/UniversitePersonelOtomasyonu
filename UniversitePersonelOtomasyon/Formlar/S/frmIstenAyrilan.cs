using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversitePersonelOtomasyon.BL.S;
using UniversitePersonelOtomasyon.Models.DataModel;

namespace UniversitePersonelOtomasyon.Formlar.S
{
    public partial class frmIstenAyrilan : Form
    {
        public frmIstenAyrilan()
        {
            InitializeComponent();
        }

        private void frmIstenAyrilan_Load(object sender, EventArgs e)
        {
            List<tblPersoneller> list = istenAyrilan.PersonelListe();
            DataTable dt = new DataTable();
            dt.Columns.Add("Personel ID");
            dt.Columns.Add("Ad");
            dt.Columns.Add("Soyad");
            dt.Columns.Add("İşe Giriş Tarihi");

            foreach(var i in list)
            {
                dt.Rows.Add(i.personel_ID, i.personel_Ad, i.personel_Soyad, i.personel_GirisTarihi);
            }
            dataGridView1.DataSource = dt;
        }
    }
}
