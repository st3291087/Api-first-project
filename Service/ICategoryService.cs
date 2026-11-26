using Entity.Models;

namespace Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> Get();
    }
}