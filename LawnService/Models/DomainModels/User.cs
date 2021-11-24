using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace LawnService.Models.DomainModels
{
    public class User : IdentityUser
    {
        public string SSN { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DoB { get; set; }
        public override string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Position { get; set; }

        [NotMapped] public IList<string> RoleNames { get; set; }
    }
}