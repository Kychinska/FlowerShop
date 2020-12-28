using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using FlowerShop.Data.Repositories;
using FlowerShop.EF.Repositories;
using FlowerShop.Domain.Interfaces;
using FlowerShop.Domain.DefaultImplementations;
namespace FlowerShop
{
    public class Kernel
    {
        public IKernel kernel;
        public Kernel()
        {
            kernel = new StandardKernel();
            kernel.Bind<IFlowerRepository>().To<FlowerRepository>();
            kernel.Bind<IPackagingRepository>().To<PackagingRepository>();
            kernel.Bind<IBouquetRepository>().To<BouquetRepository>();
            kernel.Bind<IOrderRepository>().To<OrderRepository>();
            kernel.Bind<IProductFlowerRepository>().To<ProductFlowerRepository>();
            kernel.Bind<IProductPackagingRepository>().To<ProductPackagingRepository>();
            kernel.Bind<IPackagingPriceRepository>().To<PackagingPriceRepository>();
            kernel.Bind<IFlowerPriceRepository>().To<FlowerPriceRepository>();
            kernel.Bind<IUser>().To<Form1>();
            kernel.Bind<IBoquetPrice>().To<BouquetPrice>();
            kernel.Bind<IOrderPrice>().To<OrderPrice>();
            kernel.Bind<IOrderFactory>().To<OrderFactory>();
            kernel.Bind<IBouquetFactory>().To<BouquetFactory>();
            kernel.Bind<IBouquetInOrderFactory>().To<BouquetInOrderFactory>();
            kernel.Bind<IFlowerInShopDTORepository>().To<FlowerInShopDTORepository>();
            kernel.Bind<IPackagingInShopDTORepository>().To<PackagingInShopDTORepository>();
        }
    }

    static class Program
    {

        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Kernel kernel = new Kernel();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((Form1) kernel.kernel.Get<IUser>());
        }
    }
}

