﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clinic.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }

        [Required]
        public int? FirstnameId { get; set; }
        [ForeignKey("FirstnameId")]
        public Firstname Firstname { get; set; }

        [Required]
        public int? LastnameId { get; set; }
        [ForeignKey("LastnameId")]
        public Lastname Lastname { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public string Title { get; set; }

        public string Resume { get; set; }

        public Guid? HospitalId { get; set; }
        [ForeignKey("HospitalId")]
        public Hospital Hospital { get; set; }

        public int? DepartmantId { get; set; }
        [ForeignKey("DepartmantId")]
        public Department Departmant { get; set; }

        [NotMapped]
        public string FirstnameLastname
        {
            get
            {
                return Firstname + " " + Lastname;
            }
        }
    }
}
