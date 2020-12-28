using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{
    public class PackagingInShopDTO
    {
        public int PackagingId { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int PackagingNumber { get; set; }
    }
}
