using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;


namespace UniversitePersonelOtomasyon.BL.S
{
    public class EgitimIslemleri
    {
        public static List<tblEgitim> EgitimGetir(string OgrenimSeviyesi, string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var PID = (from i in db.tblPersoneller
                               where i.kullanici_ID == KID
                               select i.personel_ID).SingleOrDefault();

                    List<tblEgitim> E = new List<tblEgitim>();
                    var egitim = (from i in db.tblEgitim
                                  where i.ogrenim_seviyesi == OgrenimSeviyesi && i.personel_ID == PID
                                  select i).ToList();

                    foreach(var i in egitim)
                    {
                        E.Add(i);
                    }
                    return E;
                }
            }catch(Exception e)
            {
                return null;
            }
        }

        public static List<tblYabanciDil> YabanciDilGetir(string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<tblYabanciDil> YDil = new List<tblYabanciDil>();
                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var PID = (from i in db.tblPersoneller
                               where i.kullanici_ID == KID
                               select i.personel_ID).SingleOrDefault();

                    var yabanciDil = (from i in db.tblYabanciDil
                                      where i.personel_ID == PID
                                      select i).ToList();
                    foreach(var i in yabanciDil)
                    {
                        YDil.Add(i);
                    }
                    return YDil;
                }
            }catch(Exception ex)
            {
                return null;
            }
        }

        public static string OgrenimBilgileriEkle(EgitimView EV, string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var PID = (from i in db.tblPersoneller
                               where i.kullanici_ID == KID
                               select i.personel_ID).SingleOrDefault();

                    tblEgitim E = new tblEgitim();
                    E.okul_Adi = EV.OkulAdi;
                    E.bolum = EV.BolumAdi;
                    E.giris_Tarihi = EV.Baslangic;
                    E.mezuniyet_Tarihi = EV.Mezuniyet;
                    E.ogrenim_seviyesi = EV.OgrenimSeviyesi;
                    E.personel_ID = PID;

                    db.tblEgitim.Add(E);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return "No";
            }
        }

        public static string YabanciDilEkle(YabanciDilView YDV, string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var PID = (from i in db.tblPersoneller
                               where i.kullanici_ID == KID
                               select i.personel_ID).SingleOrDefault();

                    tblYabanciDil YD = new tblYabanciDil();
                    YD.yabanci_Dil = YDV.YabanciDil;
                    YD.sinav_Tarihi = YDV.SinavTarihi;
                    YD.puan = YDV.Puan;
                    YD.personel_ID = PID;

                    db.tblYabanciDil.Add(YD);
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
