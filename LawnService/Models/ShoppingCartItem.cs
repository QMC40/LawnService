using System.ComponentModel.DataAnnotations;

namespace LawnService.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

        //ID to allow deletion of cart data
        public string ShoppingCartId { get; set; }
    }
}
