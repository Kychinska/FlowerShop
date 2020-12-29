using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;
namespace FlowerShop.EF.Repositories
{
    public class ProductPackagingRepository : IProductPackagingRepository
    {
        public void AddProductPackaging(ProductPackaging product)
        {
            using (var ctx = new FlowerShopContext())
            {
                ctx.ProductPackaging.Add(product);
                ctx.SaveChanges();
            }
        }

        public ProductPackaging Get(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.ProductPackaging.Where(p => p.Id == id).Single();
            }
        }

        public void RemoveProductPackaging(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                var product = ctx.ProductPackaging.Find(id);
                ctx.ProductPackaging.Remove(product);
                ctx.SaveChanges();
            }
        }
    }
}
