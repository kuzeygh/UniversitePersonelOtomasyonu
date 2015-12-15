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
    }
}
