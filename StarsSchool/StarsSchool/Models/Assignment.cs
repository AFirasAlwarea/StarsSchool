using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarsSchool.Models
{
    public class Assignment
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DeadLine { get; set; }

        public int CourseId { get; set; }

    }
}