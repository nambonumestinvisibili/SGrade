﻿using System.ComponentModel;

namespace SGrade.Models
{
    public class Teacher : IGradable
    {
        public Major Major { get; set; }
        public int MajorId { get; set; }

    }
}