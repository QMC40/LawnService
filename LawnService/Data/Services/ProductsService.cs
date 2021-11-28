using System.Threading.Tasks;
using LawnService.Data.Base;
using LawnService.Models;

namespace LawnService.Data.Services
{
    public class ProductsService : EntityBaseRepository<Product>, IProductsService
    {
        private readonly LawnServiceDbContext _context;

        public ProductsService(LawnServiceDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            return product;
        }
    }
}