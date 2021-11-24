using System;
using System.ComponentModel.DataAnnotations;

namespace LawnService.Models.DomainModels
{
    public class Job
    {
        [Key] public int JobId { get; set; }

        public int PositionId { get; set; }
        public int StoreId { get; set; }

        public DateTime OpenDate { get; set; }

        public DateTime CloseDate { get; set; }
    }
}