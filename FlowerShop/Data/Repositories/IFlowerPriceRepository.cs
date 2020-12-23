using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;

namespace FlowerShop.Data.Repositories
{
    public interface IFlowerPriceRepository
    {
        void AddPrice(FlowerPrice flowerPrice);
        void RemoveFlowerPrice(int Id);
        FlowerPrice GetFlowerPrice(int flowerId);
        List<FlowerPrice> GetAllFlowerPrices();
        void Update(FlowerPrice flowerPrice);
    }
}
