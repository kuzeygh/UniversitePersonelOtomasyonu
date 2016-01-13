using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon.BL.S
{
    public class CezaIslemleri
    {
        public static List<tblCezaBilgiler> CezaGetir()
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<tblCezaBilgiler> liste = new List<tblCezaBilgiler>();
                    var Cezalar = (from i in db.tblCezaBilgiler
                                   select i).ToList();
                    foreach(var i in Cezalar)
                    {
                        liste.Add(i);
                    }
                    return liste;
                }
            }catch(Exception ex)
            {
                return null;
            }
        }

        public static List<int> IDGetir()
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<int> list = new List<int>();
                    var PID = (from i in db.tblPersoneller
                               select i.personel_ID).ToList();
                    foreach(var i in PID)
                    {
                        list.Add(i);
                    }
                    return list;
                }
            }catch(Exception e)
            {
                return null;
            }
        }

        public static string CezaEkle(CezaView CV)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    tblCezaBilgiler CB = new tblCezaBilgiler();
                    CB.ceza = CV.Ceza;
                    CB.gun_Sayisi = CV.CezaGunSayisi;
                    CB.baslangic_Tarihi = CV.Baslangic;
                    CB.bitis_Tarihi = CV.Bitis;
                    CB.personel_ID = CV.PersonelId;

                    db.tblCezaBilgiler.Add(CB);
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
