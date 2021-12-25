using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Models
{
    public class Lastname
    {
        public int Id { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
