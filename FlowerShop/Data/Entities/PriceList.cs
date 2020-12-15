using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities
{
    public class PriceList
    {
        public List<FlowerPrice> FlowersPrice { get; set; }
        public List<PackagingPrice> PackagingPrice{ get; set; }
    }
    public class FlowerPrice
    {
        public int FlowerId { get; set; }
        public decimal PriceFlower { get; set; }
    }
    public class PackagingPrice
    {
        public int PackagingId { get; set; }
        public decimal PricePackaging { get; set; }
    }
}
