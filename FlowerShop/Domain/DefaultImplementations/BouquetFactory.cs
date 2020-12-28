using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Domain.Interfaces;
namespace FlowerShop.Domain.DefaultImplementations
{
    public class BouquetFactory : IBouquetFactory
    {
        public BouquetFactory()
        {

        }
        public Bouquet CreateBouquet(List<ProductFlower> productFlowers, string message, ProductPackaging productPackaging)
        {
            Bouquet bouquet = new Bouquet();
            bouquet.Flowers = productFlowers;
            bouquet.Message = message;
            bouquet.Packaging = productPackaging;
            bouquet.PackagingId = productPackaging.PackagingId;
            return bouquet;
        }
    }
}
