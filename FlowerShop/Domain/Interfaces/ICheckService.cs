using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data.Entities;
namespace FlowerShop.Domain.Interfaces
{
    public interface ICheckService
    {
        bool CheckBouquetsNumber(int bouquetsNumber, Bouquet bouquet);
    }
}
