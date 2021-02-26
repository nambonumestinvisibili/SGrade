using System.ComponentModel;

namespace SGrade.Models
{
    public class Subject : IGradable
    {
        public Major Major { get; set; }
        public int MajorId { get; set; }

    }
}