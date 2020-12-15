using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{    public class Order
    {
        public List<BouquetInOrder> BouquetInOrders { get; set; }
        public List<FlowerInOrder> FlowerInOrders { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Client Client { get; set; }
        public int Id { get; set; }
    }
}
