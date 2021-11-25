using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace LawnService.Models
{
    public class User : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public override string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }

        [NotMapped] public IList<string> RoleNames { get; set; }
    }
}