using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Domain.Interfaces
{
    public interface IProduct
    {
        decimal Price(int Id);
        string Name(int Id);
        int Num(int Id);
    }
}
