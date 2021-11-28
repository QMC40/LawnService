using System.ComponentModel.DataAnnotations;
using LawnService.Data.Base;

namespace LawnService.Models
{
    public class Product : IEntityBase
    {
        [Key]
        public int ProdId { get; set; }
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Price per unit")]
        [Required(ErrorMessage = "Price is required")]
        public double CostPerUnit { get; set; }
        [Display(Name = "Product description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

    }
}
