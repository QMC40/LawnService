using System.Threading.Tasks;
using LawnService.Data.Services;
using LawnService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LawnService.Areas.Admin.Controllers
{
    //xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
    // [Authorize(Roles = UserRoles.Admin)]
    [Area("Admin")]

    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var allProducts = await _productsService.GetAllAsync();
            return View(allProducts);
        }

        public async Task<IActionResult> ProductManager()
        {
            var allProducts = await _productsService.GetAllAsync();
            return View(allProducts);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productsService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                await _productsService.AddAsync(product);
                return RedirectToAction(nameof(ProductManager));
            }

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productsService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.ProdId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _productsService.UpdateAsync(id, product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProdId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(ProductManager));
            }

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _productsService.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _productsService.GetByIdAsync(id);
            if (producerDetails == null) return View();

            await _productsService.DeleteAsync(id);
            return RedirectToAction(nameof(ProductManager));
        }

        private bool ProductExists(int id)
        {
            return (_productsService.GetProductByIdAsync(id) != null);
        }
    }
}