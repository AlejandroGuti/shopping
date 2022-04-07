using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class ChangePasswordViewModel
    {
        [DataType(DataType.Password)]
        [Display(Name ="Current Password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The field {0} must be major than 6 characters.")]
        [Required(ErrorMessage ="The field {0} it's mandatory")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The field {0} must be major than 6 characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory")]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage ="The new password must be the same than confirmation one.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The field {0} must be major than 6 characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory")]
        public string Confirm { get; set; }

    }
}
