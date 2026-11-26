using Entity.Models;

namespace Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> Get();
    }
}