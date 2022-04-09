using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class RecoverPasswordViewModel
    {
        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "The field {0} must be valid")]
        [EmailAddress(ErrorMessage = "Field {0} is mandatory.")]
        public string Email { get; set; }
    }
}
