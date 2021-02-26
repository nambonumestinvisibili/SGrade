using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SGrade.Models
{
    public abstract class IGradable : IEntity
    {
        public string Name { get; set; }
        [DefaultValue(2.5)]
        public float StarsRating { get; set; }
        public ICollection<Review> Reviews { get; set; }
        [DefaultValue(false)]
        public bool IsConfirmed { get; set; }
        [DefaultValue(0)]
        [Range(-10, 10)]
        public int Votes { get; set; }
    }
}

