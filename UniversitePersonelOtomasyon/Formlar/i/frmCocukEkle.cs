using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitePersonelOtomasyon.Formlar.i
{
    public partial class frmCocukEkle : Form
    {
        public frmCocukEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Adı Soyadı");
            dt.Columns.Add("Cinsiyeti");
            dt.Columns.Add("Doğum Tarihi");
            dt.Columns.Add("Okuduğu Okul");

            dt.Rows.Add(txtAdi.Text);
            dt.Rows.Add(cbCinsiyeti.SelectedItem);
            dt.Rows.Add(dtpDogumTarihi.Value);
            dt.Rows.Add(txtOkuduguOkul.Text);
        }
    }
}
