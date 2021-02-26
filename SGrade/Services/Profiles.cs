using AutoMapper;
using SGrade.Models;
using SGrade.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGrade.Services
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<IGradable, LightGradableDTO>();
            CreateMap<Major, MajorDTO>();
            CreateMap<University, UniversityDTO>();
            CreateMap<Subject, SubjectDTO>();
            CreateMap<Teacher, TeacherDTO>();

        }
    }
}
