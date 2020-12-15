using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{
    public class FlowerPrice
    {   
        public int Id { get; set; }   
        public int FlowerId { get; set; }
        public decimal PriceFlower { get; set; }
        public int Number { get; set; }
    }
    public class PackagingPrice
    {
        public int Id { get; set; }
        public int PackagingId { get; set; }
        public decimal PricePackaging { get; set; }
        public int Number { get; set; }
    }
}
