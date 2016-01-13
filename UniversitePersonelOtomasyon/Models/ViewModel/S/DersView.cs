using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitePersonelOtomasyon.Models.ViewModel.S
{
    public class DersView
    {
        public string Ders { get; set; }
        public string BaslangicSaat { get; set; }
        public string BitisSaat { get; set; }
        public string DersGunu { get; set; }
        public int SinifId { get; set; }
    }
}
