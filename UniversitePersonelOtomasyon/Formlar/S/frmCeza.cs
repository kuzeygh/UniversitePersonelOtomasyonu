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
    public partial class frmCeza : Form
    {
        public frmCeza()
        {
            InitializeComponent();
        }

        private void frmCeza_Load(object sender, EventArgs e)
        {
            List<tblCezaBilgiler> list = CezaIslemleri.CezaGetir();
            DataTable dt = new DataTable();
            dt.Columns.Add("Ceza ID");
            dt.Columns.Add("Ceza");
            dt.Columns.Add("Baslangic Tarihi");
            dt.Columns.Add("Bitis Tarihi");
            dt.Columns.Add("Personel ID");

            foreach(var item in list)
            {
                dt.Rows.Add(item.ceza_ID, item.ceza, item.baslangic_Tarihi, item.bitis_Tarihi, item.personel_ID);
            }
            dataGridView1.DataSource = dt;
        }

        private void btnCezaEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
