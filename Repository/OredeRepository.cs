using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class OredeRepository : IOredeRepository
    {
        Project_APIContext _dbContext;
        public OredeRepository(Project_APIContext MyDb)
        {
            this._dbContext = MyDb;
        }
        public async Task<Order> Post(Order order)
        {
            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();
            return order;
        }
        public async Task<Order> Get(int OrderId)
        {
            return await _dbContext.Orders.FindAsync(OrderId);
        }
    }
}
