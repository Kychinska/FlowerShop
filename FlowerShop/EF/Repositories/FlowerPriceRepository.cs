using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;
namespace FlowerShop.EF.Repositories
{
    public class FlowerPriceRepository : IFlowerPriceRepository
    {
        public void AddPrice(FlowerPrice flowerPrice)
        {
            using (var ctx = new FlowerShopContext())
            {
                ctx.FlowerPrices.Add(flowerPrice);
                ctx.SaveChanges();
            }
        }

        public FlowerPrice GetFlowerPrice(int flowerId)
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.FlowerPrices.Where(f => f.FlowerId == flowerId).Single();
            }
        }

        public void RemoveFlowerPrice(int Id)
        {
            using (var ctx = new FlowerShopContext())
            {
                var price = ctx.FlowerPrices.Find(Id);
                ctx.FlowerPrices.Remove(price);
                ctx.SaveChanges();
            }
        }

        public void Update(FlowerPrice flowerPrice)
        {
            using (var ctx = new FlowerShopContext())
            {
                ctx.FlowerPrices.Attach(flowerPrice);
                ctx.Entry(flowerPrice).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
