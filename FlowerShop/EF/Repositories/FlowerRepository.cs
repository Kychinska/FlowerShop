using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;
using FlowerShop.Domain.Interfaces;
namespace FlowerShop.EF.Repositories
{
    public class FlowerRepository : IFlowerRepository
    {
        public FlowerRepository() 
        {

        }

        public void AddFlower(Flower flower)
        {
            using (var ctx = new FlowerShopContext ()) 
            {
                ctx.Flowers.Add(flower);
                ctx.SaveChanges();
            }
        }       

        public Flower Get(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.Flowers.Where(f => f.Id == id).Single();
            }
        }
        public void RemoveFlower(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                var flower= ctx.Flowers.Find(id);
                ctx.Flowers.Remove(flower);
                ctx.SaveChanges();
            }
        }
    }
}
