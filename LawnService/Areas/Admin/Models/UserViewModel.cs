using System.Collections.Generic;
using LawnService.Models.DomainModels;
using Microsoft.AspNetCore.Identity;

namespace LawnService.Areas.Admin.Models
{
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}