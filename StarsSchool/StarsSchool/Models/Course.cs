using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarsSchool.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Subject { get; set; }

        public string Duration { get; set; }

        [Display(Name = "Teacher")]
        public int TeacherId { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}