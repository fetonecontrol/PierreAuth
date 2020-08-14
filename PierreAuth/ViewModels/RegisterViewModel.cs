using System.ComponentModel.DataAnnotations;

namespace PierreAuth.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Description = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Description = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Description = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}