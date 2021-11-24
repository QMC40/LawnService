using System;
using System.Threading.Tasks;
using LawnService.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LawnService.Models
{
    public class JobManagerContext : IdentityDbContext<User>
    {
        public JobManagerContext(DbContextOptions<JobManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Position> Positions { get; set; }

        public DbSet<Store> Stores { get; set; }

        // public DbSet<User> Users { get; set; }
        public DbSet<Result> Results { get; set; }

        //delete
        // protected override void OnConfiguring(
        //     DbContextOptionsBuilder optionsBuilder)
        // {
        //     // code that configures the DbContext goes here
        //     base.OnConfiguring(optionsBuilder);
        // }

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
                    SSN = "000-00-0001",
                    FName = "Trogdor",
                    LName = "Burninator",
                    DoB = new DateTime(2021, 01, 01),
                    PhoneNumber = "555-1212",
                    Address = "Countryside",
                    Position = 1
                },
                new User
                {
                    UserName = "Duke@yahoops.com",
                    Email = "Duke@yahoops.com",
                    SSN = "123-45-6789",
                    FName = "John",
                    LName = "Wayne",
                    DoB = new DateTime(1934, 01, 01),
                    PhoneNumber = "555-4242",
                    Address = "southside",
                    Position = 3
                },
                new User
                {
                    UserName = "OMGawd@yahoops.com",
                    Email = "OMGawd@yahoops.com",
                    SSN = "987-65-4321",
                    FName = "Tammy",
                    LName = "Baker",
                    DoB = new DateTime(1995, 01, 01),
                    PhoneNumber = "555-3578",
                    Address = "Portland",
                    Position = 2
                },
                new User
                {
                    UserName = "wyrm@yahoops.com",
                    Email = "wyrm@yahoops.com",
                    SSN = "556-28-1867",
                    FName = "Larry",
                    LName = "Linville",
                    DoB = new DateTime(1981, 01, 01),
                    PhoneNumber = "555-8946",
                    Address = "Annaville",
                    Position = 2
                }
            );

            modelBuilder.Entity<Job>().HasData(
                new Job
                {
                    JobId = 1,
                    PositionId = 2,
                    StoreId = 2,
                    OpenDate = new DateTime(2021, 11, 16),
                    CloseDate = new DateTime(2021, 12, 31)
                },
                new Job
                {
                    JobId = 2,
                    PositionId = 3,
                    StoreId = 4,
                    OpenDate = new DateTime(2021, 11, 16),
                    CloseDate = new DateTime(2021, 12, 31)
                },
                new Job
                {
                    JobId = 3,
                    PositionId = 2,
                    StoreId = 1,
                    OpenDate = new DateTime(2021, 11, 16),
                    CloseDate = new DateTime(2021, 12, 31)
                },
                new Job
                {
                    JobId = 4,
                    PositionId = 2,
                    StoreId = 2,
                    OpenDate = new DateTime(2021, 11, 16),
                    CloseDate = new DateTime(2021, 12, 31)
                }
            );


            modelBuilder.Entity<Store>().HasData(
                new Store
                {
                    StoreId = 1,
                    Location = "Airline",
                    ManagerId = 1,
                    StaffReq = 2
                },
                new Store
                {
                    StoreId = 2,
                    Location = "Holly",
                    ManagerId = 1,
                    StaffReq = 4
                },
                new Store
                {
                    StoreId = 3,
                    Location = "Staples",
                    ManagerId = 4,
                    StaffReq = 4
                },
                new Store
                {
                    StoreId = 4,
                    Location = "SPID",
                    ManagerId = 2,
                    StaffReq = 6
                }
            );

            modelBuilder.Entity<Position>().HasData(
                new Position
                {
                    PositionId = 1,
                    PositionName = "Applicant"
                },
                new Position
                {
                    PositionId = 2,
                    PositionName = "Counter Staff"
                },
                new Position
                {
                    PositionId = 3,
                    PositionName = "Shift Manager"
                },
                new Position
                {
                    PositionId = 4,
                    PositionName = "Manager"
                },
                new Position
                {
                    PositionId = 5,
                    PositionName = "Owner"
                }
            );
            modelBuilder.Entity<Result>().HasData(
                new Result
                {
                    ResultId = 1,
                    Hired = false,
                    Comments = "couldn't pass test"
                },
                new Result
                {
                    ResultId = 2,
                    Hired = false,
                    Comments = "failed to show for interview"
                },
                new Result
                {
                    ResultId = 3,
                    Hired = true,
                    Comments = "excellent candidate"
                }
            );
        }

        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            var userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            var Email = "admin@quickstop.com";
            var username = "admin@quickstop.com";
            var password = "Sesame";
            var roleName = "Admin";
            var FName = "Admin";
            var LName = "Admin";
            var SSN = "000-00-0000";
            var PhoneNumber = "000-0000";
            var Address = "none";

            // if role doesn't exist, create it
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
    }
}