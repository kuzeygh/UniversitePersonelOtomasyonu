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
    public partial class frmOgrenimBilgileri : Form
    {
        public frmOgrenimBilgileri()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmOgrenimBilgileriEkleme OBE = new frmOgrenimBilgileriEkleme();
            OBE.Show();
        }
    }
}
