using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Models
{
    public class EditProductViewModel
    {
        [Display(Name = "Name")]
        [MaxLength(50, ErrorMessage = "The field {0} required min. {1} Characters.")]
        [Required(ErrorMessage = "The field {0} it's required.")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Description")]
        [MaxLength(500, ErrorMessage = "The field {0} required min. {1} Characters.")]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Price")]
        [Required(ErrorMessage = "The field {0} it's required.")]
        public decimal Price { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "Stock")]
        [Required(ErrorMessage = "The field {0} it's required.")]
        public float Stock { get; set; }
    }
}
