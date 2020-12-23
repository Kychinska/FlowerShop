using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;
namespace FlowerShop.EF.Repositories
{
    public class PackagingPriceRepository : IPackagingPriceRepository
    {
        public void AddPrice(PackagingPrice packagingPrice)
        {
            using (var ctx = new FlowerShopContext())
            {
                ctx.PackagingPrices.Add(packagingPrice);
                ctx.SaveChanges();
            }
        }

        public List<PackagingPrice> GetAllPackagingPrices()
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.PackagingPrices.ToList();
            }
        }

        public PackagingPrice GetPackagingPrice(int packagingId)
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.PackagingPrices.Where(p=>p.PackagingId == packagingId).Single();
            }
        }

        public void RemoveFlowerPrice(int Id)
        {
            using (var ctx = new FlowerShopContext())
            {
                var price = ctx.PackagingPrices.Find(Id);
                ctx.PackagingPrices.Remove(price);
                ctx.SaveChanges();
            }
        }

        public void Update(PackagingPrice packagingPrice)
        {
            using (var ctx = new FlowerShopContext())
            {
                ctx.PackagingPrices.Attach(packagingPrice);
                ctx.Entry(packagingPrice).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
