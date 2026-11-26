using System;
using System.Collections.Generic;
using System.Text;
using Entity.Models;
using Repository;

namespace Service
{
    public class OrderService : IOrderService
    {
        IOredeRepository oredeRepository;
        public OrderService(IOredeRepository oredeRepository)
        {
            this.oredeRepository = oredeRepository;
        }
        public async Task<Order> Post(Order order)
        {
            return await oredeRepository.Post(order);
        }
        public async Task<Order> Get(int id)
        {
            return await oredeRepository.Get(id);
        }
    }
}
