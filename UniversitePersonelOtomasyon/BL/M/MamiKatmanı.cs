using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
namespace UniversitePersonelOtomasyon.BL.M
{
    class MamiKatmanı
    {
        
        static PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2();
        public static tblKullanicilar Login(string kullaniciAdi,string sifre)
        {
            try
            {
                tblKullanicilar kul = (from k in db.tblKullanicilar
                                       where k.kullanici_Ad == kullaniciAdi &&
                                       k.kullanici_Sifre == sifre
                                       select k).SingleOrDefault();
                return kul;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }

            
            
        }
        public static tblPersoneller PersonelDetails(int PersonelID)
        {
            try
            {
                tblPersoneller per = (from p in db.tblPersoneller
                                       where p.personel_ID == PersonelID
                                      select p).SingleOrDefault();
                return per;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable Search(string Name)
        {
            try
            {
                var result = (from x in db.tblPersoneller
                              where x.personel_Ad == Name
                              select new
                              {
                                  ID = x.personel_ID,
                                  Ad = x.personel_Ad,
                                  Soyad = x.personel_Soyad,
                                  GirisTarihi = x.personel_GirisTarihi
                              }).ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Ad");
                dt.Columns.Add("Soyad");
                dt.Columns.Add("Giris Tarihi");
                foreach (var item in result)
                    dt.Rows.Add(item.ID, item.Ad, item.Soyad, item.GirisTarihi);
                return dt;
            }
            catch
            {
                return null;
            }
            
        }
        public static string userName(int personelID)
        {
            string kAdi = "";
            try
            {
                kAdi = (from x in db.tblPersoneller
                        join y in db.tblKullanicilar on x.kullanici_ID equals y.kullanici_ID
                        select y.kullanici_Ad).SingleOrDefault().ToString();
                return kAdi;
            }catch
            {
                return null;
            }
        }
        public static bool istenCikar(tblPersoneller person)
        {
            try
            {
                var per = (from p in db.tblPersoneller
                           where p.personel_ID == person.personel_ID
                           select p).SingleOrDefault();
                per.statu_ID = 2;
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
        public static bool Save (tblPersoneller person)
        {
            try
            {
                var per = (from p in db.tblPersoneller
                           where p.personel_ID == person.personel_ID
                           select p).SingleOrDefault();
                per.personel_Ad = person.personel_Ad;
                per.personel_GirisTarihi = person.personel_GirisTarihi;
                per.personel_Resim = person.personel_Resim;
                per.personel_Soyad = person.personel_Soyad;
                db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

            
        }
    }
}
