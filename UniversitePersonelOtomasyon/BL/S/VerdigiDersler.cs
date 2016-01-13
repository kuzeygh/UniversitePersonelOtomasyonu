using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;
using UniversitePersonelOtomasyon.Formlar.M;

namespace UniversitePersonelOtomasyon.BL.S
{
    public class VerdigiDersler
    {
        public static List<tblVerdigiDersler> DersGetir(string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<tblVerdigiDersler> DV = new List<tblVerdigiDersler>();

                    var KI = (from i in db.tblKullanicilar
                              where i.kullanici_Ad == KAd
                              select i.kullanici_ID).SingleOrDefault();

                    var PI = (from i in db.tblPersoneller
                              where i.kullanici_ID == KI
                              select i.personel_ID).SingleOrDefault();

                    var Dersler = (from i in db.tblVerdigiDersler
                                   where i.personel_ID == PI
                                   select i).ToList();

                    foreach(var i in Dersler)
                    {
                        DV.Add(i);
                    }
                    return DV;
                }
            }catch(Exception e)
            {
                return null;
            }
        }

        public static string DersEkle(DersView DV, string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    tblVerdigiDersler VD = new tblVerdigiDersler();
                    VD.ders = DV.Ders;
                    VD.ders_Baslangic_Saat = DV.BaslangicSaat;
                    VD.ders_Bitis_Saat = DV.BitisSaat;
                    VD.ders_Gunu = DV.DersGunu;
                    VD.sinif_ID = DV.SinifId;

                    var KI = (from i in db.tblKullanicilar
                              where i.kullanici_Ad == KAd
                              select i.kullanici_ID).SingleOrDefault();

                    var PI = (from i in db.tblPersoneller
                              where i.kullanici_ID == KI
                              select i.personel_ID).SingleOrDefault();

                    VD.personel_ID = PI;
                    db.tblVerdigiDersler.Add(VD);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return "No";
            }
        }

        public static List<int> SinifIdGetir()
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<int> Idler = new List<int>();
                    var ID = (from i in db.tblSinif
                              select i.sinif_ID).ToList();

                    foreach(var i in ID)
                    {
                        Idler.Add(i);
                    }
                    return Idler;
                }
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
