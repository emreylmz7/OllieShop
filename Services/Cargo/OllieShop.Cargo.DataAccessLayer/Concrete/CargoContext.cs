﻿using Microsoft.EntityFrameworkCore;
using OllieShop.Cargo.EntityLayer.Concrete;

namespace OllieShop.Cargo.DataAccessLayer.Concrete
{
    public class CargoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1445;initial Catalog=OllieShopCargoDb;User=sa;Password=123456aA*");
            //Database = OllieShopOrderDb; Trusted_Connection = True; TrustServerCertificate = True
        }
        
        public DbSet<CargoCompany> CargoCompanies { get; set; }
        public DbSet<CargoDetail> CargoDetails { get; set; }
        public DbSet<CargoCustomer> CargoCustomers { get; set; }
        public DbSet<CargoOperation> CargoOperations { get; set; }
    }
}
