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
        public async Task<(List<Product> Items, int TotalCount)> Get(int positon=1,int skip=10,string? desc,int? minPrice,int? maxPrice,int?[] categoryIds)
        {
            var query = _dbContext.Products.Where(Product =>
            (desc == null ? (true) : (Product.Description.Contains(desc)))
            && ((minPrice == null) ? (true) : (Product.Price >= minPrice))
            && ((maxPrice == null) ? (true) : (Product.Price <= maxPrice))
             && ((categoryIds.Length == 0) ? (true) : (categoryIds.Contains(Product.CategoryId))))
                .OrderBy(Product => Product.Price);
            
            List<Product> products = await query.Skip((positon - 1) * skip)
                .Take(skip).Include(product => product.Category).ToListAsync();
            var total = await query.CountAsync();

            return (products, total);
        }
        

            
        }
        
    }

