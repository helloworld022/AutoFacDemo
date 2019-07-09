using IOC.Model;
using System;

namespace IOC.Repository
{
    public interface IProductRepository
    {
        Product GetProduct(long Id);
    }
}
