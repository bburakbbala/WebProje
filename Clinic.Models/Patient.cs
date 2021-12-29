using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Patient
    {
        public Guid Id { get; set; }

        [Required]
        public string Identity { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public Gender Gender { get; set; }

        public short? BloodTypeId { get; set; }
        [ForeignKey("BloodTypeId")]
        public BloodType BloodType { get; set; }

        public int? MotherNameId { get; set; }
        [ForeignKey("MotherNameId")]
        public Firstname MotherName { get; set; }

        public int? FatherNameId { get; set; }
        [ForeignKey("FatherNameId")]
        public Firstname FatherName { get; set; }

        public int? FirstnameId { get; set; }
        [ForeignKey("FirstnameId")]
        public Firstname Firstname { get; set; }

        public int? LastnameId { get; set; }
        [ForeignKey("LastnameId")]
        public Lastname Lastname { get; set; }

        public int? ProfessionId { get; set; }
        [ForeignKey("ProfessionId")]
        public Profession Profession { get; set; }

        [Required]
        public string AddressDetail { get; set; }

        public int? CountryOrRegionId { get; set; }
        [ForeignKey("CountryOrRegionId")]
        public CountryOrRegion CountryOrRegion { get; set; }

        public int? CityId { get; set; }
        [ForeignKey("CityId")]
        public Province City { get; set; }

        public int? ProvinceId { get; set; }
        [ForeignKey("ProvinceId")]
        public Province Province { get; set; }

        [NotMapped]
        public string GetFirstnameLastname => Firstname + " " + Lastname;

        [NotMapped]
        public int GetAge => DateTime.Now.Year - BirthDate.Date.Year;

    }
}
