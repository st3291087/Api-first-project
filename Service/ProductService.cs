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
      
        public async Task<(List<Product> Items, int TotalCount)> Get(int positon, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoryIds)
        {

            return await ProductRepository.Get( positon,skip,desc, minPrice,  maxPrice,  categoryIds);
        }
    }
}
