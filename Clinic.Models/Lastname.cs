using System.ComponentModel.DataAnnotations;

namespace Clinic.Models
{
    public class Lastname
    {
        public int Id { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
