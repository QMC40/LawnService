using LawnService.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LawnService.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ShoppingCart _shoppingCart;




        public OrdersController(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }


        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var response = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(response);
        }

        // public RedirectToActionResult AddItemToShoppingCart(int id)
        // {
        //
        //
        //
        // }
        //
        // public RedirectToActionResult RemoveItemShoppingCart(int id)
        // {
        //
        //
        //
        // }

    }
}
