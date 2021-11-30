using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawnService.Models;
using Microsoft.EntityFrameworkCore;

namespace LawnService.Data.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly LawnServiceDbContext _context;

        public OrdersService(LawnServiceDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
        {
            //query not working right
            var orders = await _context.Orders.Include(n => n.OrderItems).ToListAsync();
            // .ThenInclude(n => n.ItemName).Include(n => n.User).ToListAsync();

            if (userRole != "Admin")
            {
                orders = orders.Where(n => n.UserId == userId).ToList();
            }

            return orders;
        }

        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId)
        {
            var order = new Order()
            {
                UserId = userId
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Quantity = item.Amount,
                    ProdId = item.Id,
                    OrderId = order.OrderId,
                    Price = item.Product.CostPerUnit
                };
                await _context.OrderItems.AddAsync(orderItem);
            }

            await _context.SaveChangesAsync();
        }
    }
}