using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitePersonelOtomasyon.Models.ViewModel.S
{
    public class GenelBilgilerView
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string KanGrubu { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public string Fakulte { get; set; }
        public string Bolum { get; set; }
        public string Unvan { get; set; }
    }
}
