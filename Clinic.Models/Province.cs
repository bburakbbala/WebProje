using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
