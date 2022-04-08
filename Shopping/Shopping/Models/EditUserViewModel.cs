using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Document")]
        [MaxLength(20, ErrorMessage = "The field {0} should have max {1} characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string Document { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The field {0} should have max {1} characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "The field {0} should have max {1} characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string LastName { get; set; }

        [Display(Name = "Address")]
        [MaxLength(200, ErrorMessage = "The field {0} should have max {1} characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string Address { get; set; }

        [Display(Name = "Telephone")]
        [MaxLength(20, ErrorMessage = "The field {0} should have max {1} characters.")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Picture")]
        public Guid ImageId { get; set; }

        [Display(Name = "Picture")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:7059/images/noimage.png"
            : $"https://agshopping.blob.core.windows.net/users/{ImageId}";
        
        [Display(Name = "Image")]
        public IFormFile? ImageFile { get; set; }

        [Display(Name = "Country")]
        [Range(1,int.MaxValue, ErrorMessage = "You should select almost 1 {0}")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public int CountryId { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

        [Display(Name = "State")]
        [Range(1, int.MaxValue, ErrorMessage = "You should select almost 1 {0}")]
        [Required(ErrorMessage = "The field {0} it's mandatory.")]
        public int StateId { get; set; }

        public IEnumerable<SelectListItem> States { get; set; }

        [Display(Name = "City")]
        [Range(1, int.MaxValue, ErrorMessage = "You should select almost 1 {0}")]
        public int CityId { get; set; }

        public IEnumerable<SelectListItem> Cities { get; set; }

    }
}
