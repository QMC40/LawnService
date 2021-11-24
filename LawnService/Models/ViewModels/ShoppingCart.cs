using System;
using System.Collections.Generic;
using System.Linq;
using LawnService.Data;
using LawnService.Models.DomainModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LawnService.Models.ViewModels
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
            var shoppingCartItem = _context.ShoppingCartItems.FirstOrDefault
            (n => n.product.ProductId == product.ProductId
                  && n.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    ShoppingCartId = ShoppingCartId,
                    product = product,
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
            (n => n.product.ProductId == product.ProductId
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

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??= _context.ShoppingCartItems.Where
                (n => n.ShoppingCartId == ShoppingCartId).ToList();
        }

        public double GetShoppingCartTotal()
        {
            var total = _context.ShoppingCartItems.Where
                (n => n.ShoppingCartId == ShoppingCartId).Select
                (n => n.product.CostPerHour * n.Amount).Sum();
            return total;
        }
    }
}