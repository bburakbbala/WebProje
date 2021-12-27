using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class PatientMedicine
    {
        public int Id { get; set; }

        public Guid? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public int? MedicineId { get; set; }
        [ForeignKey("MedicineId")]
        public Medicine Medicine { get; set; }

        public int? MedicineUsageId { get; set; }
        [ForeignKey("MedicineUsageId")]
        public MedicineUsage MedicineUsage { get; set; }
    }
}
