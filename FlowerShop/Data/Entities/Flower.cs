using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{
    public class Flower
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}
