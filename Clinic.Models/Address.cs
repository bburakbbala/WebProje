using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        public string AddressDetail { get; set; }

        public int? ContryOrRegionCode { get; set; }
        [ForeignKey("ContryOrRegionCode")]
        public CountryOrRegion ContryOrRegion { get; set; }

        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public Province City { get; set; }

        public int? ProvinceId { get; set; }
        [ForeignKey("ProvinceId")]
        public Province Province { get; set; }

    }
}
