//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversitePersonelOtomasyon.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblIletisim
    {
        public int iletisim_ID { get; set; }
        public string ev_Adresi { get; set; }
        public string ev_Tel { get; set; }
        public string cep_Tel { get; set; }
        public string e_Posta { get; set; }
        public Nullable<int> personel_ID { get; set; }
        public Nullable<int> il_ID { get; set; }
        public Nullable<int> ilce_ID { get; set; }
    }
}
