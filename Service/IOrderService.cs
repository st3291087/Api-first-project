using Entity.Models;

namespace Service
{
    public interface IOrderService
    {
        Task<Order> Post(Order order);
        public Task<Order> Get(int id);
    }
}