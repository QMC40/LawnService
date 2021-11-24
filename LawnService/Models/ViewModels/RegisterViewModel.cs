using System;
using System.ComponentModel.DataAnnotations;

namespace LawnService.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter valid email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "First name required.")]
        [StringLength(60, ErrorMessage = "enter something", MinimumLength = 3)]
        public string FName { get; set; }

        [Required(ErrorMessage = "Last name required")]
        [StringLength(60, ErrorMessage = "enter something", MinimumLength = 3)]
        public string LName { get; set; }

        [Required(ErrorMessage = "Date of Birth required.")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        [Required(ErrorMessage = "Please enter current address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter valid phone number.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}