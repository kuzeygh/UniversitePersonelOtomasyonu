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
                using(PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
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

        public static List<tblKullanicilar> KullaniciGetir()
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<tblKullanicilar> KV = new List<tblKullanicilar>();

                    var kullanicilar = (from i in db.tblKullanicilar
                                        select i).ToList();

                    foreach(var i in kullanicilar)
                    {
                        KV.Add(i);
                    }
                    return KV;
                }
            }catch(Exception e)
            {
                return null;
            }
        }
    }
}
