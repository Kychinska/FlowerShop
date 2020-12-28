using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;

namespace FlowerShop.EF.Repositories
{
    public class BouquetRepository : IBouquetRepository
    {
        public BouquetRepository() { }
        public void AddBouquet(Bouquet bouquet)
        {
            using(var ctx = new FlowerShopContext())
            {
                bouquet.DateTimeOfCreateBouquet = DateTime.Now;
                ctx.Bouquets.Add(bouquet);
                ctx.SaveChanges();
            }
        }

        public Bouquet Get(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.Bouquets.Include("Flowers").Include("Packaging").Where(b => b.Id == id).Single();
            }
        }

        public void RemoveBouquet(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                var bouquet = ctx.Bouquets.Find(id);
                ctx.Bouquets.Remove(bouquet);
                ctx.SaveChanges();
            }
        }
    }
}
