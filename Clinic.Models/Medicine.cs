using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class Medicine
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int? MedicineCategoryId { get; set; }
        [ForeignKey("MedicineCategoryId")]
        public MedicineCategory MedicineCategory { get; set; }
    }
}
