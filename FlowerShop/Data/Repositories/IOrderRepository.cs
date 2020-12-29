using FlowerShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Repositories
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        void RemoveOrder(int orderId);
    }
}
