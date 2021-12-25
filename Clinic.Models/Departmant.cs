using System.ComponentModel.DataAnnotations;

namespace Clinic.Models
{
    public class Departmant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}