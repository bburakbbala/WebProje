using System.ComponentModel.DataAnnotations;

namespace Clinic.Models
{
    public class Firstname
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
    }
}
