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
    
    public partial class tblYabanciDil
    {
        public int yabanciDil_ID { get; set; }
        public string yabanci_Dil { get; set; }
        public Nullable<System.DateTime> sinav_Tarihi { get; set; }
        public Nullable<int> puan { get; set; }
        public Nullable<int> personel_ID { get; set; }
    }
}
