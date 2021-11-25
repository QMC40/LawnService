using System.Collections.Generic;
using LawnService.Models;
using Microsoft.AspNetCore.Identity;

namespace LawnService.Areas.Admin.Models
{
    public class UserVM
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}