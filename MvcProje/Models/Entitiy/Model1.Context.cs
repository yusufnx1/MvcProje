﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcProje.Models.Entitiy
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MvcDbStokEntities : DbContext
    {
        public MvcDbStokEntities()
            : base("name=MvcDbStokEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TBLKategoriler> TBLKategoriler { get; set; }
        public virtual DbSet<TBLMusteri> TBLMusteri { get; set; }
        public virtual DbSet<TBLSatis> TBLSatis { get; set; }
        public virtual DbSet<TBLUrunler> TBLUrunler { get; set; }
    }
}