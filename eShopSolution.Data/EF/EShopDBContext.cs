using eShopSolution.Data.Configurations;
using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext( DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            //  base.OnModelCreating(modelBuilder);
        }

        //Khai bao cac Entities

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Oder> Oders { get; set; }

        public DbSet<OderDetail> OderDetails { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Producttranslation> Producttranslations { get; set; }

        public DbSet<Catagoriestranslation> Catagoriestranslations { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<SystemActivity> SystemActivities { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<AppConfig> AppConfigs { get; set; }



    }
}
