using AutoMapper;
using dentist;
using Dentist.Core.DTOs;
using Dentist.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dentist.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Doctors, DoctorDto>().ReverseMap();
            CreateMap<turn, TurnDoctorDto>().ReverseMap();
        }
    }
}
