using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;

namespace FlowerShop.EF.Repositories
{
    public class PackagingRepository : IPackagingRepository
    {
        public void AddPackaging(Packaging packaging)
        {
            using (var ctx = new FlowerShopContext()) 
            {
                ctx.Packagings.Add(packaging);
                ctx.SaveChanges();
            }
        }

        public Packaging Get(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.Packagings.Where(f => f.Id == id).Single();
            }
        }

        public List<Packaging> GetAllPackaging()
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.Packagings.ToList();
            }
        }

        public void RemovePackaging(int id)
        {
            using (var ctx = new FlowerShopContext())
            {
                var packaging = ctx.Packagings.Find(id);
                ctx.Packagings.Remove(packaging);
                ctx.SaveChanges();
            }
        }
    }
}
