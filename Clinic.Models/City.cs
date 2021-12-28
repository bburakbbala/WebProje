using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? CountryOrRegionCode { get; set; }
        [ForeignKey("CountryOrRegionCode")]
        public CountryOrRegion CountryOrRegion { get; set; }
    }
}
