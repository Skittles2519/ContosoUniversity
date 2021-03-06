﻿using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Last Name")]

        public string LastName { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Enrollment Date")]

        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}