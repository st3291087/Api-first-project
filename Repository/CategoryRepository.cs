using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        Project_APIContext db;
        public CategoryRepository(Project_APIContext db)
        {
            this.db = db;
        }
        public async Task<IEnumerable<Category>> Get()
        {
            return await db.Categories.ToListAsync();
        }
    }
}
