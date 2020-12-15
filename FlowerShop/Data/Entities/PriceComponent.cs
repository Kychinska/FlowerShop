using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{
    public class PriceComponent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public int BouquetId { get; set; }
        public Bouquet Bouquet { get; set; }
    }
}
