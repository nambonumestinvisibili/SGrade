using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGrade.Models.DTOs
{
    public class LightGradableDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float StarsRating { get; set; }
    }

    public class MajorDTO : Major
    {
        public string Type { get; set; } = "Major";
    }
    public class UniversityDTO : University
    {
        public string Type { get; set; } = "University";
    }
    public class SubjectDTO : Subject
    {
        public string Type { get; set; } = "Subject";
    }
    public class TeacherDTO : Teacher
    {
        public string Type { get; set; } = "Teacher";
    }
}
