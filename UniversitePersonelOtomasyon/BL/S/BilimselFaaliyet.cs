using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon.BL.S
{
    public class BilimselFaaliyet
    {
        public static string FaaliyetEkle(BilimselFaaliyetView Faaliyet, string KAd)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    var KId = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    tblFaaliyet FA = new tblFaaliyet()
                    {
                        yayin_Turu = Faaliyet.YayinTuru,
                        adi = Faaliyet.Adi,
                        yayin_Tarihi = Faaliyet.YayinTarihi,
                        puan = Faaliyet.Puan,
                        personel_ID = (from i in db.tblPersoneller
                                       where i.kullanici_ID == KId
                                       select i.personel_ID).SingleOrDefault()
                    };
                    db.tblFaaliyet.Add(FA);
                    db.SaveChanges();
                    return "Yes";
                }
            }catch(Exception e)
            {
                return "No";
            }
        }

        public static List<tblFaaliyet> FaaliyetGetir(string KAd)
        {
            try
            {
                using(PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<tblFaaliyet> FA = new List<tblFaaliyet>();

                    var KId = (from i in db.tblKullanicilar
                               where i.kullanici_Ad == KAd
                               select i.kullanici_ID).SingleOrDefault();

                    var PId = (from i in db.tblPersoneller
                               where i.kullanici_ID == KId
                               select i.personel_ID).SingleOrDefault();

                    var Faaliyetler = (from i in db.tblFaaliyet
                                       where i.personel_ID == PId
                                       select i).ToList();

                    foreach(var i in Faaliyetler)
                    {
                        FA.Add(i);
                    }
                    return FA;
                }
            }catch(Exception e)
            {
                return null;
            }
        }
    }
}
