using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;
using FlowerShop.Domain.Interfaces;
namespace FlowerShop.Domain.DefaultImplementations
{
   public class CheckService: ICheckService
    {
        protected IFlowerPriceRepository _flowerPriceRepository;
        protected IPackagingPriceRepository _packagingPriceRepository;
        public CheckService(IFlowerPriceRepository flowerPriceRepository,IPackagingPriceRepository packagingPriceRepository)
        {
            _flowerPriceRepository = flowerPriceRepository;
            _packagingPriceRepository = packagingPriceRepository;
        }
        public bool CheckBouquetsNumber(int bouquetsNumber, Bouquet bouquet)
        {
            if (bouquetsNumber < 1)
            {
                bouquetsNumber = 1;
            }
            foreach (var flower in bouquet.Flowers)
            {
                int requestedNumber = flower.Number * bouquetsNumber;
                if (requestedNumber > _flowerPriceRepository.GetAvailableFlowerNumber(flower.FlowerId))
                {
                    return true;
                }
            }
            if (bouquetsNumber > _packagingPriceRepository.GetAvailablePacakagingNumber(bouquet.PackagingId))
            {
                return true;
            }
            return false;
        }
    }
}
