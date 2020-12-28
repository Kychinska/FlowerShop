using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using FlowerShop.Domain.Interfaces;
using System.Windows.Forms;
namespace FlowerShop.Domain.DefaultImplementations
{
    class Create : ICreate
    {
        protected IBoquetPrice _boquetPrice;
        protected IOrderPrice _orderPrice;
        public Create (IBoquetPrice boquetPrice, IOrderPrice orderPrice)
        {
            _boquetPrice = boquetPrice;
            _orderPrice = orderPrice;
        }
        public BouquetInOrder CreateBouquetInOrder(Bouquet bouquet, int bouquetsNumber)
        {
            BouquetInOrder bouquetInOrder = new BouquetInOrder();
            bouquetInOrder.BouquetId = bouquet.Id;
            bouquetInOrder.Price = _boquetPrice.CalculateBouquetPrice(bouquetInOrder.BouquetId);
            return bouquetInOrder;
        }

        public Order CreateOrder(List<BouquetInOrder> bouquetInOrders, DateTime deliveryDate, string firstName, string lastName, string deliveryAddress, string phone)
        {
            Order order = new Order();
            Client client = new Client();
            client.DeliveryAddress = deliveryAddress;
            client.FirstName = firstName;
            client.LastName = lastName;
            client.Phone = phone;
            order.DeliveryDate = deliveryDate;
            order.BouquetInOrders = bouquetInOrders;
            order.Price = _orderPrice.CalculateOrderPrice(order);
            order.Client = client;
            return order; 
        }

        Bouquet ICreate.CreateBouquet(List<int> FlowerId, List<int> FlowerNumber, int packagingId, string message)
        {
            Bouquet bouquet = new Bouquet();
            bouquet.Flowers = new List<ProductFlower>();
            for (int i = 0; i < FlowerId.Count; i++)
            {
                ProductFlower productFlower = new ProductFlower();
                productFlower.FlowerId = FlowerId[i];
                productFlower.Number = FlowerNumber[i];
                bouquet.Flowers.Add(productFlower);
            }           
            ProductPackaging productPackaging = new ProductPackaging();
            productPackaging.PackagingId = packagingId;
            bouquet.Packaging = productPackaging;
            bouquet.PackagingId = productPackaging.PackagingId;
            bouquet.Message = message;
            return bouquet;
        }
        
    }
}
