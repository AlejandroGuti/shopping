using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shopping.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Display(Name = "City")]
        [MaxLength(50, ErrorMessage = "The field {0} must be max {1} characters.")]
        [Required(ErrorMessage = "field {0} is mandatory.")]
        public string Name { get; set; }
        [JsonIgnore]
        public State State { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
