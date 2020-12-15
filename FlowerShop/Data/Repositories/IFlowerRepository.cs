using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;

namespace FlowerShop.Data.Repositories
{
    public interface IFlowerRepository
    {
        void AddFlower(Flower flower);
        void RemoveFlower(int id);
        Flower Get(int id);
        List<Flower> GetAllFlowers();
    }
}
