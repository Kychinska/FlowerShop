using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;

namespace FlowerShop.Data.Repositories
{
  public  interface IProductFlowerRepository
    {
        void AddProductFlower(ProductFlower product);
        void RemoveProductFlower(int id);
        ProductFlower Get(int id);
    }
}
