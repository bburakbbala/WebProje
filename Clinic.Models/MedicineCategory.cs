using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class MedicineCategory
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
