using System.ComponentModel.DataAnnotations;

namespace LawnService.Data.ViewModels
{
    public class ChangePasswordVM
    {
        [Required(ErrorMessage = "Please enter password.")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Please enter new password.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}