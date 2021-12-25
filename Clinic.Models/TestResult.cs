using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class TestResult
    {
        public int Id { get; set; }

        [DisplayName("Test Name")]
        public string Name { get; set; }

        public DateTime ResultDate { get; set; }

        public DateTime SampleDate { get; set; }

        public DateTime LabAccaptanceDate { get; set; }

        public string Note { get; set; }

        public Guid? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public Guid? LabId { get; set; }
        [ForeignKey("LabId")]
        public Lab Lab { get; set; }

        public Guid? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
    }
}
