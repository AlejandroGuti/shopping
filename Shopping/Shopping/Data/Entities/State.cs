using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shopping.Data.Entities
{
    public class State
    {
        public int Id { get; set; }
        [Display(Name = "State")]
        [MaxLength(50, ErrorMessage = "The field {0} must be max {1} characters.")]
        [Required(ErrorMessage = "field {0} is mandatory.")]
        public string Name { get; set; }
        [JsonIgnore]
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
        [Display(Name = "CityCount")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
