using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SGrade.Models
{
    public class University : IGradable
    {
        public ICollection<Major> Majors { get; set; }

    }
}
