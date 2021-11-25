using System;
using System.Threading.Tasks;
using LawnService.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LawnService.Data
{
    public class LawnServiceDbContext : IdentityDbContext<User>
    {
        public LawnServiceDbContext(DbContextOptions<LawnServiceDbContext> options)
            : base(options)
        {
        }

        public DbSet<EstimateRequest> EstimateRequests { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            var userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var Email = "admin@lawnservice.com";
            var username = "admin@lawnservice.com";
            var password = "LawnCare";
            var roleName = "Admin";
            var FName = "Admin";
            var LName = "Admin";
            var SSN = "000-00-0000";
            var PhoneNumber = "000-0000";
            var Address = "none";

            // // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
                await roleManager.CreateAsync(new IdentityRole(roleName));

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new() { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded) await userManager.AddToRoleAsync(user, roleName);
            }
        }

        public DbSet<Product> Product { get; set; }
    }
}
