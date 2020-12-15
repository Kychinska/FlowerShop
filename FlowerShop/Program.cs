using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using FlowerShop.Data.Repositories;
using FlowerShop.EF.Repositories;
using FlowerShop.Domain.Interfaces;
namespace FlowerShop
{
    //public class Kernel
    //{
    //    public IKernel kernel;
    //    public Kernel()
    //    {
    //        kernel = new StandardKernel();
    //        kernel.Bind<IFlowerRepository>().To<FlowerRepository>();
    //        //kernel.Bind<IUser>().ToMethod<Form1>(kernel.GetAll<IFlowerRepository>);
    //    }


        static class Program
        {

            /// Главная точка входа для приложения.
            /// </summary>
            [STAThread]
            static void Main()
            {
                //Kernel kernel = new Kernel();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);               
                Application.Run(new Form1());

            }
        }
    }

