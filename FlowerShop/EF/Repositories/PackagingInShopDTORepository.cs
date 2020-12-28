using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;
namespace FlowerShop.EF.Repositories
{
    class PackagingInShopDTORepository : IPackagingInShopDTORepository
    {
        public List<PackagingInShopDTO> GetAvailablePackagings()
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.PackagingPrices.Join(ctx.Packagings, pp => pp.PackagingId, p => p.Id, (pp, p) => new PackagingInShopDTO() 
                { PackagingId=p.Id, Color=p.Color, Material=p.Material, PackagingNumber=pp.Number, Price= pp.PricePackaging }).ToList();               
            }
        }
    }
}
