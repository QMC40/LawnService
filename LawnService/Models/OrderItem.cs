using System.ComponentModel.DataAnnotations;

namespace LawnService.Models
{
    public class OrderItem
    {
        [Key]
        public int ItemId { get; set; }
        public int ProdId { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int OrderId { get; set; }
    }
}
