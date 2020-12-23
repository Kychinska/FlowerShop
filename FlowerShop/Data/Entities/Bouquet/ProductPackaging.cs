using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{
    public class ProductPackaging
    {
        public int Id { get; set; }
        public int PackagingId { get; set; }
        public Bouquet Bouquet { get; set; }
    }
}
