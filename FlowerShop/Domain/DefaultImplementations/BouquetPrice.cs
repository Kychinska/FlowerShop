using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Domain.Interfaces;
using FlowerShop.Data.Repositories;
namespace FlowerShop.Domain.DefaultImplementations
{
    public class BouquetPrice : IBoquetPrice
    {
        protected IPackagingPriceRepository _packagingPriceRepository;
        protected IFlowerPriceRepository _flowerPriceRepository;
        protected IBouquetRepository _bouquetRepository;
        public BouquetPrice (IPackagingPriceRepository packagingPriceRepository, IFlowerPriceRepository flowerPriceRepository, 
                                IBouquetRepository bouquetRepository)
        {
            _packagingPriceRepository = packagingPriceRepository;
            _flowerPriceRepository = flowerPriceRepository;
            _bouquetRepository = bouquetRepository;
        }
        public decimal CalculateBouquetPrice(Bouquet bouquet)
        {
            decimal price = 0;
            FlowerPrice flowerPrice;
            PackagingPrice packagingPrice =_packagingPriceRepository.GetPackagingPrice(bouquet.PackagingId);
            price +=packagingPrice.PricePackaging;
            for (int i=0; i<bouquet.Flowers.Count;i++)
            {
                flowerPrice = _flowerPriceRepository.GetFlowerPrice(bouquet.Flowers[i].FlowerId);
                price= price+ (flowerPrice.PriceFlower *bouquet.Flowers[i].Number);
            }
            return price;
        }

        public decimal CalculateBouquetPrice(int bouquetId)
        {
            decimal price = 0;
            Bouquet bouquet = _bouquetRepository.Get(bouquetId);
            FlowerPrice flowerPrice;
            PackagingPrice packagingPrice = _packagingPriceRepository.GetPackagingPrice(bouquet.PackagingId);
            price += packagingPrice.PricePackaging;
            for (int i = 0; i < bouquet.Flowers.Count; i++)
            {
                flowerPrice = _flowerPriceRepository.GetFlowerPrice(bouquet.Flowers[i].FlowerId);
                price += (flowerPrice.PriceFlower * bouquet.Flowers[i].Number);
            }
            return price;
        }
    }
}
