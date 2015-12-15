using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitePersonelOtomasyon
{
    public partial class frmOzelNot : Form
    {
        public frmOzelNot()
        {
            InitializeComponent();
        }

        private void btnOzelNotEkle_Click(object sender, EventArgs e)
        {
            frmOzelNotEkle ONE = new frmOzelNotEkle();
            ONE.Show();
        }

        private void bntOzelNotGuncelle_Click(object sender, EventArgs e)
        {
            frmOzelNotGuncelle ONG = new frmOzelNotGuncelle();
            ONG.Show();
        }
    }
}
