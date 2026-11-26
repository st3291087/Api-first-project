using Entity.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ProductService : IProductService
    {
        IProductRepository ProductRepository;
        public ProductService(IProductRepository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }
        public async Task<IEnumerable<Product>> Get()
        {

            return await ProductRepository.Get();
        }
    }
}
