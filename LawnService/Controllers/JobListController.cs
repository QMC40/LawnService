using System.Linq;
using LawnService.Models;
using LawnService.Models.DomainModels;
using Microsoft.AspNetCore.Mvc;

namespace LawnService.Controllers
{
    public class JobListController : Controller
    {
        public JobListController(JobManagerContext ctx)
        {
            Context = ctx;
        }

        private JobManagerContext Context { get; }


        // GET
        public IActionResult Index()
        {
            var jobs = Context.Jobs.OrderBy(j => j.JobId).ToList();
            return View(jobs);
        }

        //disabled till identity db implemented
        //[Authorize]
        public IActionResult JobAdmin()
        {
            var jobs = Context.Jobs.OrderBy(j => j.JobId).ToList();
            return View(jobs);
        }

        public IActionResult Add()
        {
            ViewBag.Action = "Add Job";
            return View("Edit", new Job());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit Job";
            var job = Context.Jobs.Find(id);
            return View(job);
        }

        [HttpPost]
        public IActionResult Edit(Job job)
        {
            if (ModelState.IsValid)
            {
                if (job.JobId == 0)
                    Context.Jobs.Add(job);
                else
                    Context.Jobs.Update(job);

                Context.SaveChanges();
                return RedirectToAction("JobAdmin");
            }

            ViewBag.Action = job.JobId == 0 ? "Add" : "Edit";
            return View(job);
        }

        [HttpGet]
        public IActionResult Apply(int id)
        {
            var job = Context.Jobs.Find(id);
            return RedirectToAction("Apply", "Application", job);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var job = Context.Jobs.Find(id);
            return View(job);
        }

        [HttpPost]
        public IActionResult Delete(Job job)
        {
            Context.Jobs.Remove(job);
            Context.SaveChanges();
            return RedirectToAction("JobAdmin");
        }
    }
}