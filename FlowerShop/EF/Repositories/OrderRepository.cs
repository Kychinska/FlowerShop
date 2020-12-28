using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Data.Repositories;

namespace FlowerShop.EF.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order)
        {
            using (var ctx = new FlowerShopContext())
            {
                ctx.Orders.Add(order);
                ctx.SaveChanges();
            }
        }
        public Order GetOrder(int orderId)
        {
            using (var ctx = new FlowerShopContext())
            {
                return ctx.Orders.Where(o => o.Id == orderId).Single();
            }
        }

        public void RemoveOrder(int orderId)
        {
            using (var ctx = new FlowerShopContext())
            {
                var order = ctx.Orders.Find(orderId);
                ctx.Orders.Remove(order);
                ctx.SaveChanges();
            }
        }

        
    }
}
