using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon.BL.S
{
    public class GenelBilgiler
    {
        public static string GenelBilgilerEkle(GenelBilgilerView Genel,string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    tblPersoneller Personel = new tblPersoneller();
                    Personel.personel_Ad = Genel.Ad;
                    Personel.personel_Soyad = Genel.Soyad;
                    Personel.personel_GirisTarihi = Genel.IseGirisTarihi;
                    Personel.cinsiyet_ID = (from i in db.tblCinsiyet
                                            where i.cinsiyet == Genel.Cinsiyet
                                            select i.cinsiyet_ID).SingleOrDefault();
                    Personel.fakulte_ID = (from i in db.tblFakülte
                                           where i.fakutle == Genel.Fakulte
                                           select i.fakulte_ID).SingleOrDefault();
                    Personel.departman_ID = (from i in db.tblDepartman
                                             where i.departman == Genel.Bolum
                                             select i.departman_ID).SingleOrDefault();
                    Personel.unvan_ID = (from i in db.tblUnvan
                                         where i.unvan == Genel.Unvan
                                         select i.unvan_ID).SingleOrDefault();
                    Personel.kullanici_ID = (from i in db.tblKullanicilar
                                             where i.kullanici_Ad == KAd
                                             select i.kullanici_ID).SingleOrDefault();
                    
                    db.tblPersoneller.Add(Personel);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return "No";
            }
        }

        public static GenelBilgilerView GenelBilgilerGetir(string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var Personel = (from i in db.tblPersoneller
                                    where i.kullanici_ID == KID
                                    select i).SingleOrDefault();

                    GenelBilgilerView GBV = new GenelBilgilerView();
                    GBV.Ad = Personel.personel_Ad;
                    GBV.Soyad = Personel.personel_Soyad;
                    GBV.IseGirisTarihi = Personel.personel_GirisTarihi.Value;
                    GBV.Cinsiyet = (from i in db.tblCinsiyet
                                    where i.cinsiyet_ID == Personel.cinsiyet_ID
                                    select i.cinsiyet).SingleOrDefault();
                    GBV.Fakulte = (from i in db.tblFakülte
                                   where i.fakulte_ID == Personel.fakulte_ID
                                   select i.fakutle).SingleOrDefault();
                    GBV.Bolum = (from i in db.tblDepartman
                                 where i.departman_ID == Personel.departman_ID
                                 select i.departman).SingleOrDefault();
                    GBV.Unvan = (from i in db.tblUnvan
                                 where i.unvan_ID == Personel.unvan_ID
                                 select i.unvan).SingleOrDefault();
                                        
                    return GBV;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static string SaglikSorunEkle(SaglikView Saglik,string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    tblSaglik Sag = new tblSaglik();
                    if(Saglik.SakatlikVarMi == 1) {
                        Sag.sakatlikVarMı = true;
                    }
                    else
                    {
                        Sag.sakatlikVarMı = false;
                    }
                    Sag.sakatlikDerecesi = Saglik.SakatlikDerecesi;
                    Sag.aciklama = Saglik.Aciklama;

                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    Sag.personel_ID = (from i in db.tblPersoneller
                                       where i.kullanici_ID == KID
                                       select i.personel_ID).SingleOrDefault();

                    db.tblSaglik.Add(Sag);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return "No";
            }
        }

        public static SaglikView SaglikSorunGetir(string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    SaglikView Saglik = new SaglikView();
                    var KID = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var PID = (from i in db.tblPersoneller
                               where i.kullanici_ID == KID
                               select i.personel_ID).SingleOrDefault();

                    var Sag = (from i in db.tblSaglik
                                  where i.personel_ID == PID
                                  select i).SingleOrDefault();

                    if (Sag.sakatlikVarMı == true)
                        Saglik.SakatlikVarMi = 1;
                    else
                        Saglik.SakatlikVarMi = 0;
                    Saglik.SakatlikDerecesi = Sag.sakatlikDerecesi;
                    Saglik.Aciklama = Sag.aciklama;

                    return Saglik;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
