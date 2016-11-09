using System.ComponentModel.DataAnnotations;

namespace StarsSchool.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int CourseId { get; set; }

    }
}