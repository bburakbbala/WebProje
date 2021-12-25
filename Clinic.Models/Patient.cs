using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [Required]
        public int? FirstnameId { get; set; }
        [ForeignKey("FirstnameId")]
        public Firstname Firstname { get; set; }

        [Required]
        public int? LastnameId { get; set; }
        [ForeignKey("LastnameId")]
        public Lastname Lastname { get; set; }

        public int? ProfessionId { get; set; }
        [ForeignKey("ProfessionId")]
        public Profession Profession { get; set; }

        [Required]
        public int? AddressId { get; set; }
        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        [NotMapped]
        public string GetFirstnameLastname => Firstname + " " + Lastname;

        [NotMapped]
        public int GetAge => DateTime.Now.Year - BirthDate.Date.Year;

    }
}
