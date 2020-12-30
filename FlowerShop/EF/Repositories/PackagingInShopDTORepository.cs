using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;
using System.Data.Entity;
namespace FlowerShop.EF.Repositories
{
    class PackagingInShopDTORepository : IPackagingInShopDTORepository
    {
        public List<PackagingInShopDTO> GetAvailablePackagings()
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.PackagingPrices.Join(
                    ctx.Packagings, 
                    pp => pp.PackagingId, 
                    p => p.Id, 
                    (pp, p) => new PackagingInShopDTO() 
                        { 
                            PackagingId=p.Id, 
                            Color=p.Color, 
                            Material=p.Material, 
                            Price= pp.PricePackaging,
                            PackagingNumber = pp.Number - ctx.Bouquets.Where(b => DbFunctions.DiffMinutes(b.DateTimeOfCreateBouquet, DateTime.Now) < 20)
                            .Where(b => !ctx.BouquetsInOrder.Any(bo => bo.BouquetId == b.Id))
                            .Select( b=> b.Packaging)
                            .Where(x=>x.PackagingId==p.Id )
                            .Count() 
                          }
                    ).ToList();               
                }
        }
    }
}
