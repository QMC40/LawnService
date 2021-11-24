﻿using System;

namespace LawnService.Models.DomainModels
{
    public class Employee : User
    {
        public string SSN { get; set; }
        public DateTime DoB { get; set; }
        public int Position { get; set; }
        public DateTime HireDate { get; set; }
    }
}