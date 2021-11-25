using System.Collections.Generic;
using System.Threading.Tasks;
using LawnService.Data.Base;
using LawnService.Models;
using Microsoft.EntityFrameworkCore;

namespace LawnService.Data.Services
{
    public class ProductsService : EntityBaseRepository<Product>, IProductsService
    {
        private readonly LawnServiceDbContext _context;

        public ProductsService(LawnServiceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            var productDetails = await _context.Products.FirstOrDefaultAsync();
            return productDetails;
        }
        public Task AddNewProductAsync(NewProductVM data)
        {
            throw new System.NotImplementedException();
        }
        public Task UpdateProductAsync(NewProductVM data)
        {
            throw new System.NotImplementedException();
        }
        public Task DeleteProductAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
