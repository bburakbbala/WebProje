﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class CountryOrRegion
    {
        [Key]
        // ISO 3166 Alpha-3 code
        public string ISO3166Alpha3Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}