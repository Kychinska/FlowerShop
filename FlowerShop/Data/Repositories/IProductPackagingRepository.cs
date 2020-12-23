using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
namespace FlowerShop.Data.Repositories
{
    public interface IProductPackagingRepository
    {
        void AddProductPackaging(ProductPackaging product);
        void RemoveProductPackaging(int id);
        ProductPackaging Get(int id);
        List<ProductPackaging> GetAllProductFlower();
    }
}
