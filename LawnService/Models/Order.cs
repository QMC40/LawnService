using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LawnService.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string UserId { get; set; }
        //[ForeignKey(nameof(UserId))]
        //public ApplicationUser User { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}
