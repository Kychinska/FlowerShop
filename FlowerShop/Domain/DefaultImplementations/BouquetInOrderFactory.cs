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
    public class BouquetInOrderFactory : IBouquetInOrderFactory
    {

        protected IBoquetPrice _boquetPrice;
        public BouquetInOrderFactory (IBoquetPrice boquetPrice)
        {
            _boquetPrice = boquetPrice;
        }
        public BouquetInOrder CreateBouquetInOrder(Bouquet bouquet,int bouquetsNumber)
        {     
            BouquetInOrder bouquetInOrder = new BouquetInOrder();
            bouquetInOrder.BouquetId = bouquet.Id;
            bouquetInOrder.Number = bouquetsNumber;
            bouquetInOrder.Price = _boquetPrice.CalculateBouquetPrice(bouquetInOrder.BouquetId);
            return bouquetInOrder;
        }
    }
}
