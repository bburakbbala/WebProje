using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Hospital
    {
        public Guid Id { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        [Display(Name = "Hospital Name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int? AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
    }
}
