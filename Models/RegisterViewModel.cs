using System.ComponentModel.DataAnnotations;

namespace IdentityAspNetCore.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "{0} must be less than {1}")]
        [Display(Name ="First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} must be less than {1}")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Must match Password")]
        public string ConfirmPassword { get; set; }
    }
}
