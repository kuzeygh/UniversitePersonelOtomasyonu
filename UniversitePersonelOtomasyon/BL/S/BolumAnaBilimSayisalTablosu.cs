using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;
using UniversitePersonelOtomasyon.Models.ViewModel.S;

namespace UniversitePersonelOtomasyon.BL.S
{
    public class BolumAnaBilimSayisalTablosu
    {
        public static DataTable TabloGetir(BolumAnaBilimSayisalTabloView View) 
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Fakülte");
                dt.Columns.Add("Bölüm");
                dt.Columns.Add("Prof.");
                dt.Columns.Add("Doç.");
                dt.Columns.Add("Yar.Doç.");
                dt.Columns.Add("Ars.Gör.");
                dt.Columns.Add("Okutman");

                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<string> Veriler = new List<string>();
                    List<int?> UnvanID;
                    DataRow dr = dt.NewRow();
                    var Fakulteler = (from i in db.tblFakülte
                                      where i.fakutle == View.Fakulte
                                      select i).SingleOrDefault();
                    dr[0] = Fakulteler.fakutle;
                    for (int i = 1; i < dt.Columns.Count; i++)
                        dr[i] = "";
                    dt.Rows.Add(dr);

                        var Bolumler = (from i in db.tblDepartman
                                        where i.fakulte_ID == Fakulteler.fakulte_ID && i.departman == View.Bolum
                                        select i).ToList();
                    if (View.Bolum == null)
                    {
                        Bolumler = (from i in db.tblDepartman
                                        where i.fakulte_ID == Fakulteler.fakulte_ID
                                        select i).ToList();
                    }

                    foreach (var item in Bolumler)
                    {
                        DataRow dr2 = dt.NewRow();
                        var Unvanlar = (from i in db.tblPersoneller
                                        join u in db.tblUnvan on i.unvan_ID equals u.unvan_ID
                                        where i.departman_ID == item.departman_ID
                                        group u.unvan by u.unvan_ID into d select new { UnvanID = d.Key,  Unvan = d }).ToList();
                        int x = 0;
                        dr2[x++] = "";
                        dr2[x++] = item.departman;
                        for (int i = 0; i < Unvanlar.Count; i++)
                        {
                            int id = Convert.ToInt32(Unvanlar[i].UnvanID);
                            string temp = db.tblUnvan.FirstOrDefault(z => z.unvan_ID == id ).unvan.ToString().Trim();
                            dr2[temp] = Unvanlar[i].Unvan.Count();

                        }
                        dt.Rows.Add(dr2);
                    }
                    return dt;
                }
            }catch(Exception e)
            {
                return null;
            }
        }
        public static DataTable TabloGetir2()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Fakülte");
                dt.Columns.Add("Bölüm");
                dt.Columns.Add("Prof.");
                dt.Columns.Add("Doç.");
                dt.Columns.Add("Yar.Doç.");
                dt.Columns.Add("Ars.Gör.");
                dt.Columns.Add("Okutman");
                
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<string> Veriler = new List<string>();
                    List<int?> UnvanID;
                    
                    var Fakulteler = (from i in db.tblFakülte
                                      select i).ToList();
                    foreach (var item in Fakulteler)
                    {
                        DataRow dr = dt.NewRow();
                        dr[0] = item.fakutle;
                        for (int i = 1; i < dt.Columns.Count; i++)
                            dr[i] = "";
                        dt.Rows.Add(dr);
                        var Bolumler = (from i in db.tblDepartman
                                        where i.fakulte_ID == item.fakulte_ID
                                        select i).ToList();

                        foreach (var item2 in Bolumler)
                        {
                            DataRow dr2 = dt.NewRow();
                            var Unvanlar = (from i in db.tblPersoneller
                                            join u in db.tblUnvan on i.unvan_ID equals u.unvan_ID
                                            where i.departman_ID == item2.departman_ID
                                            group u.unvan by u.unvan_ID into d
                                            select new { UnvanID = d.Key, Unvan = d }).ToList();
                            int x = 0;
                            dr2[x++] = "";
                            dr2[x++] = item2.departman;
                            for (int i = 0; i < Unvanlar.Count; i++)
                            {
                                int id = Convert.ToInt32(Unvanlar[i].UnvanID);
                                string temp = db.tblUnvan.FirstOrDefault(z => z.unvan_ID == id).unvan.ToString().Trim();
                                dr2[temp] = Unvanlar[i].Unvan.Count();

                            }
                            dt.Rows.Add(dr2);
                        }
                    }
                    return dt;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static List<string> Fakulteler()
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<string> liste = new List<string>();

                    var Fakulte = (from i in db.tblFakülte
                                   select i).ToList();
                    foreach(var item in Fakulte)
                    {
                        liste.Add(item.fakutle);
                    }

                    return liste;
                }
            }catch(Exception e)
            {
                return null;
            }
        }

        public static List<string> Bolumler(string fakulte)
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<string> liste = new List<string>();

                    var FI = (from i in db.tblFakülte
                              where i.fakutle == fakulte
                              select i.fakulte_ID).SingleOrDefault();

                    var Bolum = (from i in db.tblDepartman
                                 where i.fakulte_ID == FI                                   
                                 select i).ToList();
                    foreach (var item in Bolum)
                    {
                        liste.Add(item.departman);
                    }

                    return liste;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
