using Entity.Models;

namespace Repository
{
    public interface IOredeRepository
    {
        Task<Order> Post(Order order);
        public Task<Order> Get(int OrderItemId);
    }
}