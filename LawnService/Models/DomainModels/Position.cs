using System.ComponentModel.DataAnnotations;

namespace LawnService.Models.DomainModels
{
    public class Position
    {
        [Key] public int PositionId { get; set; }

        public string PositionName { get; set; }
    }
}