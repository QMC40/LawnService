using System.Collections.Generic;
using System.Threading.Tasks;
using LawnService.Areas.Admin.Models;
using LawnService.Models.DomainModels;
using LawnService.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LawnService.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;

        public UserController(UserManager<User> userMngr,
            RoleManager<IdentityRole> roleMngr)
        {
            userManager = userMngr;
            roleManager = roleMngr;
        }

        public async Task<IActionResult> Index()
        {
            List<User> users = new();
            foreach (var user in userManager.Users)
            {
                user.RoleNames = await userManager.GetRolesAsync(user);
                users.Add(user);
            }

            UserViewModel model = new()
            {
                Users = users,
                Roles = roleManager.Roles
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);
                if (!result.Succeeded) // if failed
                {
                    var errorMessage = "";
                    foreach (var error in result.Errors) errorMessage += error.Description + " | ";
                    TempData["message"] = errorMessage;
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user != null)
            {
                var subj = new UserEditViewModel
                {
                    Email = user.Email,
                    FName = user.FName,
                    LName = user.LName,
                    SSN = user.SSN,
                    DoB = user.DoB,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                };
                return View(subj);
            }

            return Ok("fail");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.Email);
                user.Email = model.Email;
                user.FName = model.FName;
                user.LName = model.LName;
                user.SSN = model.SSN;
                user.DoB = model.DoB;
                user.Address = model.Address;
                user.PhoneNumber = model.PhoneNumber;

                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                foreach (var error in result.Errors) ModelState.AddModelError("", error.Description);
            }

            return Ok("yep");
            //return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FName = model.FName,
                    LName = model.LName,
                    SSN = model.SSN,
                    DoB = model.DoB,
                    PhoneNumber = model.PhoneNumber,
                    Address = model.Address
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                foreach (var error in result.Errors) ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddToAdmin(string id)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                TempData["message"] = "Admin role does not exist. "
                                      + "Click 'Create Admin Role' button to create it.";
            }
            else
            {
                var user = await userManager.FindByIdAsync(id);
                await userManager.AddToRoleAsync(user, adminRole.Name);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromAdmin(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var result = await userManager.RemoveFromRoleAsync(user, "Admin");
            if (result.Succeeded)
            {
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            var result = await roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateAdminRole()
        {
            var result = await roleManager.CreateAsync(new IdentityRole("Admin"));
            if (result.Succeeded)
            {
            }

            return RedirectToAction("Index");
        }
    }
}