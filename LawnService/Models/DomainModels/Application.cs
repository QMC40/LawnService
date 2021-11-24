using System;
using System.ComponentModel.DataAnnotations;

namespace LawnService.Models.DomainModels
{
    public class Application
    {
        public Application()
        {
        }

        [Key]
        public int ApplicationId { get; set; }
        public int UserId { get; set; }
        public int JobId { get; set; }
        public DateTime ApplyDate { get; set; } = DateTime.Now;
        public int ResultId { get; set; } = 1;

        //pass / fail criteria for hirable
        public bool Disqualified { get; set; } = false;
        public bool PassedTest { get; set; } = false;
    }
}