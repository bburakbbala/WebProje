using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class Treatment
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string AdmissionNote { get; set; }

        public bool Status { get; set; }

        public Guid? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
    }
}
