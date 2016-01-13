using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitePersonelOtomasyon.Models.ViewModel.S
{
    public class EgitimView
    {
        public string OkulAdi { get; set; }
        public string BolumAdi { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Mezuniyet { get; set; }
        public string OgrenimSeviyesi { get; set; }
    }
}
