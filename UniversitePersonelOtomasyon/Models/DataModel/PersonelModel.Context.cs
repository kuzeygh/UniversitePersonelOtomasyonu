﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PersonelOtomasyonDBEntities : DbContext
    {
        public PersonelOtomasyonDBEntities()
            : base("name=PersonelOtomasyonDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<tblAtamalar> tblAtamalar { get; set; }
        public DbSet<tblCezaBilgiler> tblCezaBilgiler { get; set; }
        public DbSet<tblCinsiyet> tblCinsiyet { get; set; }
        public DbSet<tblCocukBilgisi> tblCocukBilgisi { get; set; }
        public DbSet<tblDepartman> tblDepartman { get; set; }
        public DbSet<tblEgitim> tblEgitim { get; set; }
        public DbSet<tblEvraklar> tblEvraklar { get; set; }
        public DbSet<tblFaaliyet> tblFaaliyet { get; set; }
        public DbSet<tblFakülte> tblFakülte { get; set; }
        public DbSet<tblGorev> tblGorev { get; set; }
        public DbSet<tblIdariGorev> tblIdariGorev { get; set; }
        public DbSet<tblIlceler> tblIlceler { get; set; }
        public DbSet<tblIletisim> tblIletisim { get; set; }
        public DbSet<tblIller> tblIller { get; set; }
        public DbSet<tblIzin> tblIzin { get; set; }
        public DbSet<tblKullanicilar> tblKullanicilar { get; set; }
        public DbSet<tblKullaniciTipi> tblKullaniciTipi { get; set; }
        public DbSet<tblMaas> tblMaas { get; set; }
        public DbSet<tblMadeniHali> tblMadeniHali { get; set; }
        public DbSet<tblNufusBilgiler> tblNufusBilgiler { get; set; }
        public DbSet<tblOzelNot> tblOzelNot { get; set; }
        public DbSet<tblPersoneller> tblPersoneller { get; set; }
        public DbSet<tblSaglik> tblSaglik { get; set; }
        public DbSet<tblSinif> tblSinif { get; set; }
        public DbSet<tblStatus> tblStatus { get; set; }
        public DbSet<tblUnvan> tblUnvan { get; set; }
        public DbSet<tblUyruk> tblUyruk { get; set; }
        public DbSet<tblVerdigiDersler> tblVerdigiDersler { get; set; }
        public DbSet<tblVerilisNedeni> tblVerilisNedeni { get; set; }
        public DbSet<tblYabanciDil> tblYabanciDil { get; set; }
    }
}
