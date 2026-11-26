using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        Project_APIContext _dbContext;
        public ProductRepository(Project_APIContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Product>> Get()
        {

            return await _dbContext.Products.ToListAsync();
        }
        
    }
}
