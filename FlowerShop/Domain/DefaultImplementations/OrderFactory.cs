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
    public class OrderFactory : IOrderFactory
    {
        protected IBouquetRepository _bouquetRepository;
        protected IFlowerPriceRepository _flowerPriceRepository;
        protected IOrderPrice _orderPrice;
        protected IPackagingPriceRepository _packagingPriceRepository;
        public OrderFactory(IBouquetRepository bouquetRepository,
                            IFlowerPriceRepository flowerPriceRepository, 
                            IPackagingPriceRepository packagingPriceRepository,
                            IOrderPrice orderPrice)
        {
            _bouquetRepository = bouquetRepository;
            _flowerPriceRepository = flowerPriceRepository;
            _orderPrice = orderPrice;
            _packagingPriceRepository = packagingPriceRepository;
        }
        public Order CreateOrder(List<BouquetInOrder> bouquetsInOrder,Client client, DateTime deliveryDate)
        {
            Order order = new Order();
            order.Client = client;
            order.DeliveryDate = deliveryDate;
            order.BouquetInOrders = bouquetsInOrder;
            order.Price = _orderPrice.CalculateOrderPrice(order);
            for (int i = 0; i < order.BouquetInOrders.Count; i++)
            {
                Bouquet bouquet = _bouquetRepository.Get(order.BouquetInOrders[i].BouquetId);
                for (int j = 0; j < bouquet.Flowers.Count; j++)
                {
                    FlowerShop.Data.Entities.FlowerPrice flower = _flowerPriceRepository.GetFlowerPrice(bouquet.Flowers[j].FlowerId);
                    flower.Number = flower.Number - (bouquet.Flowers[j].Number * order.BouquetInOrders[i].Number);
                    _flowerPriceRepository.Update(flower);
                }
            }
            for (int i = 0; i < order.BouquetInOrders.Count; i++)
            {
                Bouquet bouquet = _bouquetRepository.Get(order.BouquetInOrders[i].BouquetId);
                PackagingPrice packaging = _packagingPriceRepository.GetPackagingPrice(bouquet.Packaging.PackagingId);
                packaging.Number = packaging.Number - 1;
                _packagingPriceRepository.Update(packaging);
            }
            return order;
        }
    }
}
