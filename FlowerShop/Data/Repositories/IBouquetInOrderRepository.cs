using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
namespace FlowerShop.Data.Repositories
{
    public interface IBouquetInOrderRepository
    {
        BouquetInOrder GetBouquetInOrder(int bouquetInOrderId);
        void AddBouquetInOrder(BouquetInOrder bouquetInOrder);
        void RemoveBouquetInOrder(int bouquetInOrderId);
        List<BouquetInOrder> GetAllBouquetInOrder();
    }
}
