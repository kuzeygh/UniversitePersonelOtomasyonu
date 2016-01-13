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
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon
{
    public partial class frmBolumAnaBilimSayisalTablosu : Form
    {
        public frmBolumAnaBilimSayisalTablosu()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string fakulte,bolum;
            fakulte = cmbFakulteSec.SelectedItem.ToString();
            if (cmbBolumSec.SelectedIndex != -1)
                bolum = cmbBolumSec.SelectedItem.ToString();
            else
                bolum = null;
            BolumAnaBilimSayisalTabloView BABSTV = new BolumAnaBilimSayisalTabloView();
            BABSTV.Fakulte = fakulte;
            BABSTV.Bolum = bolum;

            DataTable dt = BolumAnaBilimSayisalTablosu.TabloGetir(BABSTV);

            dataGridSayisalTablo.DataSource = dt;
        }

        private void frmBolumAnaBilimSayisalTablosu_Load(object sender, EventArgs e)
        {
            dataGridSayisalTablo.DataSource = BolumAnaBilimSayisalTablosu.TabloGetir2();
            List<string> liste = BolumAnaBilimSayisalTablosu.Fakulteler();
            cmbFakulteSec.Items.Clear();
            foreach (var i in liste)
            {
                cmbFakulteSec.Items.Add(i);
            }
            
        }

        private void cmbFakulteSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> list = BolumAnaBilimSayisalTablosu.Bolumler(cmbFakulteSec.SelectedItem.ToString());
            cmbBolumSec.Items.Clear();
            cmbBolumSec.SelectedIndex = -1;
            cmbBolumSec.Text = "Seçiniz";
            foreach (var i in list)
            {
                cmbBolumSec.Items.Add(i);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
