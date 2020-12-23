using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{
    public class ProductFlower
    {
        public int Number { get; set; }
        public int Id { get; set; }
        public int FlowerId { get; set; }
        public Bouquet Bouquet { get; set; }
    }
}
