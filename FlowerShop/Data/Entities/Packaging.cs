using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{
    public class Packaging
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
    }
}
