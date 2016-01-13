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
using UniversitePersonelOtomasyon.BL.M;

namespace UniversitePersonelOtomasyon.Formlar.M
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        public static tblKullanicilar Kullanici;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            tblKullanicilar k;
            if ((k = MamiKatmanı.Login(kullaniciAdi,sifre))!= null)
            {
                Kullanici = k;
                MessageBox.Show("Giriş Başarılı",this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form frmAnaMenü = new frmParent();
                frmAnaMenü.Show();
                this.Hide();
                
            }else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Güle güle",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
