using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UniversitePersonelOtomasyon.Models.ViewModel.S
{
    public class IzinView
    {
        public string IzinTuru { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public string IzinBilgisi { get; set; }
    }
}
