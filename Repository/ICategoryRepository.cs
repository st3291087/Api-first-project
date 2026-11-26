using Entity.Models;

namespace Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> Get();
    }
}