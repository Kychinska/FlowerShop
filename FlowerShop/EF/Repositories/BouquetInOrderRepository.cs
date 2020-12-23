using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;

namespace FlowerShop.EF.Repositories
{
    class BouquetInOrderRepository : IBouquetInOrderRepository
    {
        public void AddBouquetInOrder(BouquetInOrder bouquetInOrder)
        {
            using (var ctx = new FlowerShopContext())
            {
                ctx.BouquetsInOrder.Add(bouquetInOrder);
                ctx.SaveChanges();
            }
        }

        public List<BouquetInOrder> GetAllBouquetInOrder()
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.BouquetsInOrder.Include("Bouquets").ToList();
            }
        }

        public BouquetInOrder GetBouquetInOrder(int bouquetInOrderId)
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.BouquetsInOrder.Include("Bouquets").Where(b => b.Id == bouquetInOrderId).Single();
            }
        }

        public void RemoveBouquetInOrder(int bouquetInOrderId)
        {
            using (var ctx = new FlowerShopContext())
            {
                var bouquets = ctx.BouquetsInOrder.Find(bouquetInOrderId);
                ctx.BouquetsInOrder.Remove(bouquets);
                ctx.SaveChanges();
            }
        }
    }
}
