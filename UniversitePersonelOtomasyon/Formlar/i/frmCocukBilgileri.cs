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
    public partial class frmCocukBilgileri : Form
    {
        public frmCocukBilgileri()
        {
            InitializeComponent();
        }

        private void txtCocukSayisi_TextChanged(object sender, EventArgs e)
        {

            frmCocukEkle ce = new frmCocukEkle();
            for (int i = 0; i < Convert.ToInt32(txtCocukSayisi.Text); i++)
            {
                ce.Show();
            }

        }
    }
}
