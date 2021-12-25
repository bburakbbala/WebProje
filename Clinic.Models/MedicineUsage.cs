using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class MedicineUsage
    {
        public int Id { get; set; }

        [Required]
        public int Dose { get; set; }

        [Required]
        public string TypeOfUsage { get; set; }

        [Required]
        public string Frequency { get; set; }

        [NotMapped]
        public string Instruction
        {
            get
            {
                return Frequency + " " + TypeOfUsage;
            }
        }

        [Required]
        public int? MedicineId { get; set; }
        [ForeignKey("MedicineId")]
        public Medicine Medicine { get; set; }
    }
}
