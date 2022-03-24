﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name ="Country")]
        [MaxLength(50, ErrorMessage ="The field {0} must be max {1} characters.")]
        [Required(ErrorMessage ="field {0} is mandatory.")]
        public string Name { get; set; }

    }
}