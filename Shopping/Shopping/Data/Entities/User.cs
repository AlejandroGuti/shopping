using Microsoft.AspNetCore.Identity;
using Shopping.Enum;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class User:IdentityUser
    {
        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "The field {0} should have max {1} characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string Document { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The field {0} should have max {1} characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(500, ErrorMessage = "The field {0} should have max {1} characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string LastName { get; set; }

        [Display(Name = "City")]
        public City City { get; set; }

        [Display(Name = "Address")]
        [MaxLength(200, ErrorMessage = "The field {0} should have max {1} characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string Address { get; set; }

        [Display(Name = "Picture")]
        public Guid ImageId { get; set; }

        [Display(Name = "Picture")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:7059/images/noimage.png"
            : $"https://shoppingzulu.blob.core.windows.net/users/{ImageId}";

        [Display(Name = "User Type")]
        public UserType UserType { get; set; }

        [Display(Name = "User")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "User")]
        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";
    }
}
