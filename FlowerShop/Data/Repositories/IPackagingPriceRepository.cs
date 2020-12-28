using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
namespace FlowerShop.Data.Repositories
{
    public interface IPackagingPriceRepository
    {
        void AddPrice(PackagingPrice packagingPrice);
        void RemoveFlowerPrice(int Id);
        PackagingPrice GetPackagingPrice(int packagingId);
        List<PackagingPrice> GetAllPackagingPrices();
        void Update(PackagingPrice packagingPrice);
        int GetAvailablePacakagingNumber(int packagingId);
    }
}
