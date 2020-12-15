using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;

namespace FlowerShop.Data.Repositories
{
   public interface IPackagingRepository
    {
        void AddPackaging(Packaging packaging);
        void RemovePackaging(int id);
        Packaging Get(int id);
        List<Packaging> GetAllPackaging();
    }
}
