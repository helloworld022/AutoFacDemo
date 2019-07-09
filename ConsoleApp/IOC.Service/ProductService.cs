using IOC.Model;
using IOC.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Product GetProduct(long Id)
        {
            return _productRepository.GetProduct(Id);
        }
    }
}
