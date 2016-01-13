using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon.BL.S
{
    public class OzelNotIslemleri
    {
        public static List<tblOzelNot> OzelNotGetir(string KAd)
        {
            try
            {
                using(PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<tblOzelNot> ON = new List<tblOzelNot>();

                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var PID = (from i in db.tblPersoneller
                               where i.kullanici_ID == KID
                               select i.personel_ID).SingleOrDefault();

                    var OzelNotlar = (from i in db.tblOzelNot
                                      select i).ToList();

                    foreach(var i in OzelNotlar)
                    {
                        ON.Add(i);
                    }
                    
                    return ON;
                }
            }catch(Exception e)
            {
                return null;
            }
        }

        public static string OzelNotEkle(OzelNotView ONV, string KAd)
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

                    tblOzelNot ON = new tblOzelNot();
                    ON.ozel_Not = ONV.OzelNot;
                    ON.personel_ID = PID;

                    db.tblOzelNot.Add(ON);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return "No";
            }
        }

        public static List<int> IDVer(string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<int> IDler = new List<int>();

                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var PID = (from i in db.tblPersoneller
                               where i.kullanici_ID == KID
                               select i.personel_ID).SingleOrDefault();

                    var ID = (from i in db.tblOzelNot
                              where i.personel_ID == PID
                              select i.ozelNot_ID).ToList();

                    foreach(var i in ID)
                    {
                        IDler.Add(i);
                    }
                    return IDler;
                }
            }catch(Exception e)
            {
                return null;
            }
        }

        public static string OzelNotGuncelle(OzelNotView ONV, string KAd, int ID)
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

                    var OzelNot = (from i in db.tblOzelNot
                                   where i.ozelNot_ID == ID && i.personel_ID == PID
                                   select i.ozel_Not).SingleOrDefault();

                    OzelNot = ONV.OzelNot;
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
