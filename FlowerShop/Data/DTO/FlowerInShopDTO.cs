using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data
{
    public class FlowerInShopDTO
    {
        public int FlowerId { get; set; }
        public string FlowerName { get; set; }
        public decimal FlowerPrice { get; set; }
        public string Color { get; set; }
        public int FlowerNumber { get; set; }
    }
}
