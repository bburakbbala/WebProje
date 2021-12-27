using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        public string AddressDetail { get; set; }

        public string? ContryOrRegionCode { get; set; }
        [ForeignKey("ContryOrRegionCode")]
        public CountryOrRegion ContryOrRegion { get; set; }
    }
}
