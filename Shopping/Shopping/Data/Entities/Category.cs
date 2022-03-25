using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Category")]
        [MaxLength(50, ErrorMessage = "The field {0} must be max {1} characters.")]
        [Required(ErrorMessage = "field {0} is mandatory.")]
        public string Name { get; set; }
    }
}
