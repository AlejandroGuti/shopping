using Shopping.Enum;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class AddUserViewModel :EditUserViewModel
    {
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "The email should be valid")]
        [MaxLength(100, ErrorMessage = "The field {0} Should have more than 1 characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The field {0} Should have more than {2} characters.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The pass must be the same.")]
        [Display(Name = "Confirm Pass")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The field {0} Should have more than {2} characters.")]
        public string PasswordConfirm { get; set; }

        [Display(Name = "User type")]
        public UserType UserType { get; set; }
    }
}
