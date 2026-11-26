using Entity.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository CategoryRepository;
        public CategoryService(ICategoryRepository CategoryRepository)
        {
            this.CategoryRepository = CategoryRepository;
        }
        public async Task<IEnumerable<Category>> Get()
        {
            return await CategoryRepository.Get();
        }
    }
}
