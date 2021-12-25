using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class DoctorTreatment
    {
        public int Id { get; set; }

        public Guid? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        public int? TreatmentId { get; set; }
        [ForeignKey("TreatmentId")]
        public Treatment Treatment { get; set; }
    }
}
