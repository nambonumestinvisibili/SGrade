using System.Collections.Generic;
using System.ComponentModel;

namespace SGrade.Models
{
    public class Major : IGradable
    {
        public University University { get; set; }
        public int UniversityId {get;set;}
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
        [DefaultValue("Major")]

        public string Type { get; set; } 

    }
}