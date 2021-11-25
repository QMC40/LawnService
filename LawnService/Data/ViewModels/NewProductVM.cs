using System.ComponentModel.DataAnnotations;

namespace LawnService.Data.ViewModels
{
    public class NewProductVM
    {
        public int Id { get; set; }

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