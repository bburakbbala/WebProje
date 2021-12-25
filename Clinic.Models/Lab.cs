using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Lab
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int? AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
    }
}