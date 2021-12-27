﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class HospitalDepartmant
    {
        public int Id { get; set; }

        public Guid? HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public Hospital Hospital { get; set; }

        public int? DepartmantId { get; set; }
        [ForeignKey("DepartmantId")]
        public Department Departmant { get; set; }
    }
}
