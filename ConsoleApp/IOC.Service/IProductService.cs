using IOC.Model;
using System;

namespace IOC.Service
{
    public interface IProductService
    {
        Product GetProduct(long Id);
    }
}
