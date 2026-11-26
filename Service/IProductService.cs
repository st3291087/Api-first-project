using Entity.Models;

namespace Service
{
    public interface IProductService
    {
        Task<(List<Product> Items, int TotalCount)> Get(int positon, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoryIds);
    }
}