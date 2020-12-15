
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
namespace FlowerShop.Data.Entities
{
    public class Bouquet
    {
        public List<ProductFlower> Flowers { get; set; }
        public int Id { get; set; }   
        public ProductPackaging Packaging { get; set; }
        public int PackagingId { get; set; }
        public string Message { get; set; }
       
    }
}
