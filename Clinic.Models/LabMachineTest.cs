using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class LabMachineTest
    {
        public int Id { get; set; }

        public Guid? LabMachineId { get; set; }
        [ForeignKey("LabMachineId")]
        public LabMachine LabMachine { get; set; }

        public int? TestId { get; set; }
        [ForeignKey("TestId")]
        public Test Test { get; set; }

        public double TestResult { get; set; }
    }
}
