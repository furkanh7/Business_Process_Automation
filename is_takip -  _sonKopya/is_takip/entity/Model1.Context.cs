﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace is_takip.entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbistakipEntities : DbContext
    {
        public dbistakipEntities()
            : base("name=dbistakipEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbladmin> tbladmin { get; set; }
        public virtual DbSet<tblcagrilar> tblcagrilar { get; set; }
        public virtual DbSet<tblciro> tblciro { get; set; }
        public virtual DbSet<tbldepartmanlar> tbldepartmanlar { get; set; }
        public virtual DbSet<tblfirmalar> tblfirmalar { get; set; }
        public virtual DbSet<tblgorevdetaylar> tblgorevdetaylar { get; set; }
        public virtual DbSet<tblgorevler> tblgorevler { get; set; }
        public virtual DbSet<tblilceler> tblilceler { get; set; }
        public virtual DbSet<tbliller> tbliller { get; set; }
        public virtual DbSet<tblkategori> tblkategori { get; set; }
        public virtual DbSet<tblpersonel> tblpersonel { get; set; }
        public virtual DbSet<tblurunler> tblurunler { get; set; }
        public virtual DbSet<tblsatis> tblsatis { get; set; }
    }
}
