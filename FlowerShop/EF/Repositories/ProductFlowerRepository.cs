using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;

namespace FlowerShop.EF.Repositories
{
    public class ProductFlowerRepository : IProductFlowerRepository
    {
        public void AddProductFlower(ProductFlower product)
        {
            using (var ctx = new FlowerShopContext())
            {
                ctx.ProductFlowers.Add(product);
                ctx.SaveChanges();
            }
        }
        public ProductFlower Get(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.ProductFlowers.Where(p => p.Id == id).Single();
            }
        }

        public List<ProductFlower> GetAllProductFlower()
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.ProductFlowers.ToList();
            }
        }

        public void RemoveProductFlower(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                var product = ctx.ProductFlowers.Find(id);
                ctx.ProductFlowers.Remove(product);
                ctx.SaveChanges();
            }
        }
    }
}
