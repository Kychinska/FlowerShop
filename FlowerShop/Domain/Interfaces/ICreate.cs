using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
using System.Windows.Forms;
namespace FlowerShop.Domain.Interfaces
{
    public interface ICreate
    {
        Bouquet CreateBouquet(List<int> FlowerId, List<int> FlowerNumber, int packagingId, string message);
        BouquetInOrder CreateBouquetInOrder(Bouquet bouquet, int bouquetsNumber);
        Order CreateOrder(List<BouquetInOrder> BouquetInOrders, DateTime DeliveryDate, string FirstName, string LastName, string DeliveryAddress, string Phone);
    }
}
