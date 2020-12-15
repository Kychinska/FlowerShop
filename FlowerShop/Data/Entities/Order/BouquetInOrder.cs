using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{
    public class BouquetInOrder
    {
        public int BouquetId { get; set; }
        public int Number { get; set; }
        public decimal Price { get; set; }
        public Order Order {get;set;}
        public int OrderId { get; set; }
        public int Id { get; set; }
    }
}
