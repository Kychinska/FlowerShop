using FlowerShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Domain.Interfaces
{
    public interface IOrderFactory
    {
        Order CreateOrder(List<BouquetInOrder> bouquetsInOrder, Client client, DateTime deliveryDate);
    }
}
