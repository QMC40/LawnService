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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // code that configures the DbSet entities goes here
            base.OnModelCreating(modelBuilder);

            //seed data for testing / demonstration
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserName = "hotstuff@yahoops.com",
                    Email = "hotstuff@yahoops.com",
                    NormalizedEmail = "HOTSTUFF@YAHOOPS.COM",
                    FName = "Trogdor",
                    LName = "Burninator",
                    PhoneNumber = "555-1212",
                    Address = "Countryside"
                },
                new User
                {
                    UserName = "Duke@yahoops.com",
                    Email = "Duke@yahoops.com",
                    NormalizedEmail = "DUKE@YAHOOPS.COM",
                    FName = "John",
                    LName = "Wayne",
                    PhoneNumber = "555-4242",
                    Address = "southside"
                },
                new User
                {
                    UserName = "OMGawd@yahoops.com",
                    Email = "OMGawd@yahoops.com",
                    NormalizedEmail = "OMGAWD@YAHOOPS.COM",
                    FName = "Tammy",
                    LName = "Baker",
                    PhoneNumber = "555-3578",
                    Address = "Portland"
                },
                new User
                {
                    UserName = "wyrm@yahoops.com",
                    Email = "wyrm@yahoops.com",
                    NormalizedEmail = "WYRM@YAHOOPS.COM",
                    FName = "Larry",
                    LName = "Linville",
                    PhoneNumber = "555-8946",
                    Address = "Annaville"
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProdId = 1,
                    Name = "Weed eating",
                    CostPerUnit = 50.0,
                    Description = "weedeat and edge by the hour"
                },
                new Product
                {
                    ProdId = 2,
                    Name = "Mowing",
                    CostPerUnit = 35.0,
                    Description = "Mow by the hour"
                },
                new Product
                {
                    ProdId = 3,
                    Name = "Fertilize",
                    CostPerUnit = 100.0,
                    Description = "Fertilize 100 sq ft of grass"
                },
                new Product
                {
                    ProdId = 4,
                    Name = "Leaf removal",
                    CostPerUnit = 55.0,
                    Description = "Gather and remove 100 cubic ft of leaves"
                }
            );

        }


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
            var PhoneNumber = "000-0000";
            var Address = "none";

            // // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
                await roleManager.CreateAsync(new IdentityRole(roleName));

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new()
                {
                    UserName = username,
                    Email = Email,
                    FName = FName,
                    LName = LName,
                    PhoneNumber = PhoneNumber,
                    Address = Address
                };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded) await userManager.AddToRoleAsync(user, roleName);
            }
        }

        public DbSet<Product> Product { get; set; }
    }
}
