using Autofac;
using IOC.Container;
using IOC.Service;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Container.Init();
            PrintProductMessage(1001);
            Console.ReadLine();
        }
        /// <summary>
        /// 根据ID 获取Product
        /// </summary>
        /// <param name="id"></param>
        public static void PrintProductMessage(long id)
        {
            //从容器中解析出对象
            IProductService stuService = Container.Instance.Resolve<IProductService>();
            var product = stuService.GetProduct(id);
            Console.WriteLine($"name :{product.Name}");
            Console.WriteLine($"price :{product.Price}");
            Console.WriteLine($"address :{product.Address}");
            Console.WriteLine($"Id :{product.Id}");
        }
    }
}
