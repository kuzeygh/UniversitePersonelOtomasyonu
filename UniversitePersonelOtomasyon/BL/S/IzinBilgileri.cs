using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon.BL.S
{
    public class IzinBilgileri
    {
        public static string IzınEkle(IzinView izin,string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    tblIzin iz = new tblIzin();
                    iz.izin_Turu = izin.IzinTuru;
                    iz.izin_Bilgisi = izin.IzinBilgisi;
                    iz.baslangic_Tarihi = izin.Baslangic;
                    iz.bitis_Tarihi = izin.Bitis;
                    iz.izin_Bilgisi = izin.IzinBilgisi;
                    iz.personel_ID = (from i in db.tblPersoneller
                                      where i.kullanici_ID == KID
                                      select i.personel_ID).SingleOrDefault();

                    db.tblIzin.Add(iz);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return "No";
            }
        }

        public static List<tblIzin> IzinleriGetir(string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<tblIzin> IV = new List<tblIzin>();
                    var KId = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var PID = (from i in db.tblPersoneller
                               where i.kullanici_ID == KId
                               select i.personel_ID).SingleOrDefault();

                    var izinler = (from i in db.tblIzin
                                   where i.personel_ID == PID
                                   select i).ToList();
                    
                    foreach(var i in izinler)
                    {
                        IV.Add(i);
                    }
                    return IV;
                }
            }catch(Exception e)
            {
                return null;
            }
        }
    }
}
