using LawnService.Models;
using LawnService.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LawnService.Controllers
{
    public class ApplicationController : Controller
    {
        private readonly UserManager<User> userManager;

        public ApplicationController(JobManagerContext ctx)
        {
            Context = ctx;
        }

        private JobManagerContext Context { get; }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply(Job job)
        {
            var id = userManager.GetUserId(User);
            var jobApp = new Application
            {
                JobId = job.JobId,

            };
            return View(jobApp);
        }


        [HttpPost]
        public IActionResult Apply(Application jobApp)
        {
            if (ModelState.IsValid)
            {
                Context.Applications.Add(jobApp);
                Context.SaveChanges();
                return RedirectToAction("Index", "JobList");
            }

            return Ok("something is wrong");
        }
    }
}