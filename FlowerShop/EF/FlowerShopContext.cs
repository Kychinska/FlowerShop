using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;


namespace FlowerShop.EF
{
    public class FlowerShopContext : DbContext
    {
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<Packaging> Packagings { get; set; }
        public DbSet<Bouquet> Bouquets { get; set; }
        public DbSet <ProductFlower> ProductFlowers { get; set; }
        public DbSet<ProductPackaging> ProductPackaging { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<FlowerPrice> FlowerPrices { get; set; }
        public DbSet<PackagingPrice> PackagingPrices { get; set; }
        public DbSet<BouquetInOrder> BouquetsInOrder { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<ProductFlower>().HasRequired(f => f.Bouquet).WithMany(b => b.Flowers);
            modelBuilder.Entity<Bouquet>().HasRequired(b => b.Packaging).WithOptional(p => p.Bouquet);
            modelBuilder.Entity<BouquetInOrder>().HasRequired(b => b.Order).WithMany(o => o.BouquetInOrders).HasForeignKey(b => b.OrderId);
            modelBuilder.Entity<FlowerPrice>();
            modelBuilder.Entity<PackagingPrice>();
           
        }
    }
}
