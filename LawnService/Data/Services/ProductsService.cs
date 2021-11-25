using System.Threading.Tasks;
using LawnService.Data.Base;
using LawnService.Data.ViewModels;
using LawnService.Models;
using Microsoft.EntityFrameworkCore;

namespace LawnService.Data.Services
{
    public class ProductsService : EntityBaseRepository<Product>, IProductsService
    {
        private readonly LawnServiceDbContext _context;

        public ProductsService(LawnServiceDbContext context) : base(context)
        {
            _context = context;
        }

        // public async Task<IEnumerable<Product>> GetAllAsync()
        // {
        //     var result = await _context.Products.ToListAsync();
        //     return result;
        // }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync();
            return product;
        }
        public async Task AddNewProductAsync(NewProductVM data)
        {
            var newProduct = new Product()
            {
                Name = data.Name,
                Description = data.Description,
                CostPerUnit = data.CostPerUnit,
            };
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateProductAsync(NewProductVM data)
        {
            var newProduct = new Product()
            {
                Name = data.Name,
                Description = data.Description,
                CostPerUnit = data.CostPerUnit,
            };
            await _context.Products.UpdateAsync(newProduct);
            await _context.SaveChangesAsync();
        }
        public Task DeleteProductAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
