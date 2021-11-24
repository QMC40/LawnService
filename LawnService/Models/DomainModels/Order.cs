using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LawnService.Models.DomainModels
{
    public class Order
    {
        [Key]
        public int OderId { get; set; }
        public int UserId { get; set; }

        public List<OrderItem> OrderItems { get; set; }

    }
}
