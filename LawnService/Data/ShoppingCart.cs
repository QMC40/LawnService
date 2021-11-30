using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LawnService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LawnService.Data
{
    public class ShoppingCart
    {
        public LawnServiceDbContext _context { get; set; }

        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(LawnServiceDbContext context)
        {
            _context = context;
        }
        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<LawnServiceDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);


            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }
        public void AddItemToCart(Product product)
        {

            var shoppingCartItem =
                _context.ShoppingCartItems.FirstOrDefault(n => n.Product.ProdId == product.ProdId
                                                               && n.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Amount = 1
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _context.SaveChanges();
        }
        public void RemoveItemFromCart(Product product)
        {
            var shoppingCartItem = _context.ShoppingCartItems.FirstOrDefault
            (n => n.Product.ProdId == product.ProdId
                  && n.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem != null)
            {

                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                }
                else
                {
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }

                _context.SaveChanges();
            }
        }
        public async Task ClearShoppingCartAsync()
        {
            var items = await _context.ShoppingCartItems.Where(n => n.ShoppingCartId == ShoppingCartId).ToListAsync();
            _context.ShoppingCartItems.RemoveRange(items);
            await _context.SaveChangesAsync();
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??= _context.ShoppingCartItems.Where
                (n => n.ShoppingCartId == ShoppingCartId)
                .Include(p => p.Product)
                .ToList();
        }
        public double GetShoppingCartTotal()
        {
            var total = _context.ShoppingCartItems.Where
                (n => n.ShoppingCartId == ShoppingCartId).Select
                (n => n.Product.CostPerUnit * n.Amount).Sum();
            return total;
        }
    }
}