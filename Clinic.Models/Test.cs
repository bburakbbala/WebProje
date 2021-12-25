using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class Test
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Test Name")]
        public string Name { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public string ReferenceRange { get; set; }

    }
}
