using System;
using System.ComponentModel.DataAnnotations;

namespace LawnService.Models
{
    public class EstimateRequest
    {
        public EstimateRequest()
        {
        }

        [Key]
        public int RequestId { get; set; }
        public DateTime RequestDate { get; set; } = DateTime.Now;
        public string FName { get; set; }
        public string LName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}