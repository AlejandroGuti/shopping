using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class CreateProductViewModel : EditProductViewModel
    {
        [Display(Name = "Category")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a category.")]
        [Required(ErrorMessage = "The field {0} it's required.")]
        public int CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }

        [Display(Name = "Image")]
        public IFormFile? ImageFile { get; set; }

    }
}
