﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NEWAPI.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutoTuneEntities : DbContext
    {
        public AutoTuneEntities()
            : base("name=AutoTuneEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Genders> Genders { get; set; }
        public virtual DbSet<Marks> Marks { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<MaterialsToSupplies> MaterialsToSupplies { get; set; }
        public virtual DbSet<MaterialsType> MaterialsType { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderStatuses> OrderStatuses { get; set; }
        public virtual DbSet<PaymentMethods> PaymentMethods { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PaymentStatuses> PaymentStatuses { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<ServicesToOrders> ServicesToOrders { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<Supplies> Supplies { get; set; }
        public virtual DbSet<SupplyStatuses> SupplyStatuses { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeOfServices> TypeOfServices { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}