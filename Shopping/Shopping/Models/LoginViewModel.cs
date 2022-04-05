using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class LoginViewModel
    {

        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "The field {0} must be valid")]
        [EmailAddress(ErrorMessage = "Field {0} is mandatory.")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(6, ErrorMessage = "The field {0} must be valid")]
        [Required(ErrorMessage = "Field {0} is mandatory.")]
        public string Password { get; set; }
        
        
        [Display(Name = "Remember me on this browser")]
        public bool RememberMe { get; set; }
    }
}
