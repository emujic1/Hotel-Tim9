﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelNWT
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hotelEntities : DbContext
    {
        public hotelEntities()
            : base("name=hotelEntities")
        {
            Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<food_menu> food_menu { get; set; }
        public DbSet<food_order> food_order { get; set; }
        public DbSet<image> image { get; set; }
        public DbSet<keycard> keycard { get; set; }
        public DbSet<location> location { get; set; }
        public DbSet<reservation> reservation { get; set; }
        public DbSet<resource> resource { get; set; }
        public DbSet<resource_type> resource_type { get; set; }
        public DbSet<user> user { get; set; }
    }
}