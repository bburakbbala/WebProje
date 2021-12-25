using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class Hospital
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Hospital Name")]
        public string Name { get; set; }

        [Required]
        public int? AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
    }
}
