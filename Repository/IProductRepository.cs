using Entity.Models;

namespace Repository
{
    public interface IProductRepository
    {
        Task<(List<Product> Items, int TotalCount)> Get(int positon, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoryIds);
    }
}