using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class CitiesViewModel
    {
        public int Id { get; set; }
        [Display(Name = "City")]
        [MaxLength(50, ErrorMessage = "The field {0} must be max {1} characters.")]
        [Required(ErrorMessage = "field {0} is mandatory.")]
        public string Name { get; set; }
        public int StateId { get; set; }
    }
}
