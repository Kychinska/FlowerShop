using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Data;
namespace FlowerShop.Data.Repositories
{
    public interface IFlowerInShopDTORepository
    {
       List< FlowerInShopDTO> GetAvailableFlowers();
        List<FlowerInShopDTO> GetNotAvailableFlowers();
    }
}
