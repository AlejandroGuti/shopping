using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

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

        public ICollection<ProductCategory> ProductCategories { get; set; }

        [Display(Name = "Categorie")]
        public int CategoriesNumber => ProductCategories == null ? 0 : ProductCategories.Count;

        public ICollection<ProductImage> ProductImages { get; set; }

        [Display(Name = "Image")]
        public int ImagesNumber => ProductImages == null ? 0 : ProductImages.Count;

        //TODO: Pending to change to the correct path
        [Display(Name = "Image")]
        public string ImageFullPath => ProductImages == null || ProductImages.Count == 0
            ? $"https://localhost:7259/images/noimage.png"
            : ProductImages.FirstOrDefault().ImageFullPath;
    }
}
