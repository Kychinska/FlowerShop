using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;

namespace FlowerShop.Data.Repositories
{
   public interface IBouquetRepository
    {
        void AddBouquet(Bouquet bouquet);
        void RemoveBouquet (int id);
        Bouquet Get(int id);
        List<Bouquet> GetAllBouquets();
    }
}
