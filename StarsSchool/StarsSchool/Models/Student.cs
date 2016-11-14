using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarsSchool.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

    }
}