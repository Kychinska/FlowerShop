using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Data.Entities.Storage
{
    public class Storage
    {
        public List<FlowerInStorage> FlowersInStorage { get; set; }
        public List<PackagingInStorage> PackagingInStorage { get; set; }
    }   
}
