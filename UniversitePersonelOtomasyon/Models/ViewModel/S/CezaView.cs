using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitePersonelOtomasyon.Models.ViewModel.S
{
    public class CezaView
    {
        public string Ceza { get; set; }
        public int CezaGunSayisi { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public int PersonelId { get; set; }
    }
}
