using IOC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.Repository
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProduct(long Id)
        {
            return new Product() { Id = Id, Name = "苹果", Price = 13M, Address = "陕西" };
        }
    }
}
