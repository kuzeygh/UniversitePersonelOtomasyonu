using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon.BL.S
{
    public class KullaniciIslemleri
    {
        public static string KullaniciEkle(KullaniciView Kullanici)
        {
            try
            {
                using(PersonelOtomasyonDBEntities db = new PersonelOtomasyonDBEntities())
                {
                    tblKullanicilar K = new tblKullanicilar();
                    K.kullanici_Ad = Kullanici.KAd;
                    K.kullanici_Sifre = Kullanici.Sifre;
                    K.type_ID = Kullanici.Type;
                    db.tblKullanicilar.Add(K);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return "No";
            }
        }
    }
}
