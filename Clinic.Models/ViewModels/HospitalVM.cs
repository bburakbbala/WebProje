using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Clinic.Models.ViewModels
{
    public class HospitalVM
    {
        public Hospital Hospital { get; set; }

        public IEnumerable<SelectListItem> HospitalDepartmentList { get; set; }

        public IEnumerable<SelectListItem> LabList { get; set; }

        public IEnumerable<SelectListItem> DoctorList { get; set; }

        public Address Address { get; set; }
    }
}
