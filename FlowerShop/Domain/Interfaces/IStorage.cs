using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Domain.Interfaces
{
    public interface IStorage
    {
        void AddFlowerInStorage( int FlowerId, int num);
        void AddPackagingInStorage(int PackagingId, int num);
        void Statistic();
    }
}
