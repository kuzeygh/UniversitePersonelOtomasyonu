using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversitePersonelOtomasyon.Models.DataModel;

namespace UniversitePersonelOtomasyon.BL.S
{
    public class istenAyrilan
    {
        public static List<tblPersoneller> PersonelListe()
        {
            try
            {
                using (PersonelOtomasyonDBEntities2 db = new PersonelOtomasyonDBEntities2())
                {
                    List<tblPersoneller> liste = new List<tblPersoneller>();
                    var Personeller = (from i in db.tblPersoneller
                                       where i.statu_ID == 2
                                       select i).ToList();
                    foreach(var item in Personeller)
                    {
                        liste.Add(item);
                    }
                    return liste;
                }
            }catch(Exception e)
            {
                return null;
            }
        }
    }
}
