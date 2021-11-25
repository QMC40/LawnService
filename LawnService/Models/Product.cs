using LawnService.Data.Base;

namespace LawnService.Models
{
    public class Product : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CostPerUnit { get; set; }
        public string Description { get; set; }

    }
}
