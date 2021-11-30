using System;

namespace LawnService.Models
{
    public class Employee : User
    {
        public int Position { get; set; }
        public DateTime HireDate { get; set; }
    }
}