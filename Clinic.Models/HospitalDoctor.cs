using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class HospitalDoctor
    {
        public int Id { get; set; }

        public Guid? HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public Hospital Hospital { get; set; }

        public Guid? DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
    }
}
