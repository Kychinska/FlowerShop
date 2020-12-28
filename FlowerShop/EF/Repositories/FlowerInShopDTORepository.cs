using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data;
using FlowerShop.Data.Repositories;
using System.Data.Entity;
namespace FlowerShop.EF.Repositories
{
    public class FlowerInShopDTORepository : IFlowerInShopDTORepository
    {        
        public List<FlowerInShopDTO> GetAvailableFlowers()
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.FlowerPrices.Join(ctx.Flowers, fp => fp.FlowerId, f => f.Id, (p, d) => new FlowerInShopDTO()
                { FlowerId = d.Id, FlowerName = d.Name, FlowerPrice = p.PriceFlower, Color = d.Color,
                    FlowerNumber = p.Number-ctx.Bouquets.Where(b=>DbFunctions.DiffMinutes(b.DateTimeOfCreateBouquet,DateTime.Now)<20)
                    .Where(b=> !ctx.BouquetsInOrder.Any(bo=>bo.BouquetId==b.Id)).SelectMany(b=>b.Flowers).Where(f=>f.FlowerId==d.Id).Select(f=>f.Number)
                    .DefaultIfEmpty(0).Sum()}).ToList();
            }
        }
    }
}
