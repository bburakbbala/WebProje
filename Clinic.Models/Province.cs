using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class Province
    {
        // zip codes are not unique globally
        public int Id { get; set; }
        
        [Required]
        public string ZipCode { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string? ContryOrRegionCode { get; set; }
        [ForeignKey("ContryOrRegionCode")]
        public CountryOrRegion ContryOrRegion { get; set; }
    }
}
