using System.Threading.Tasks;
using LawnService.Data.Base;
using LawnService.Models;

namespace LawnService.Data.Services
{
    public interface IProductsService : IEntityBaseRepository<Product>
    {
        Task<Product> GetProductByIdAsync(int id);
        // Task AddNewProductAsync(NewProductVM data);
        // Task UpdateProductAsync(NewProductVM data);
        // Task DeleteProductAsync(int id);
    }
}