﻿using System;
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
    public partial class frmBilimselFaaliyetler : Form
    {
        public frmBilimselFaaliyetler()
        {
            InitializeComponent();
        }

        private void btnFaaliyetEkle_Click(object sender, EventArgs e)
        {
            frmBilimselFaaliyetEkle BFE = new frmBilimselFaaliyetEkle();
            BFE.Show();
        }
    }
}
