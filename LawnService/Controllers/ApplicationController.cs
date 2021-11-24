using LawnService.Data;
using LawnService.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LawnService.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly UserManager<User> userManager;

        public ApplicationController(LawnServiceDbContext ctx)
        {
            Context = ctx;
        }

        private LawnServiceDbContext Context { get; }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }

}