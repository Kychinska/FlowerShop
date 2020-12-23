using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Domain.Interfaces;
using FlowerShop.Data.Entities;

namespace FlowerShop.Domain.DefaultImplementations
{
    public class OrderPrice : IOrderPrice
    {
        decimal IOrderPrice.OrderPrice(Order order)
        {
            decimal price = 0;
            for(int i = 0; i<order.BouquetInOrders.Count();i++)
            {
                price += order.BouquetInOrders[i].Price * order.BouquetInOrders[i].Number;
            }
            return price;
        }
    }
}
