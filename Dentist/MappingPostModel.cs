using AutoMapper;
using Dentist.Api.Models;
using Dentist.Core.Entities;

namespace Dentist.Api
{
    public class MappingPostModel : Profile

    {
        public MappingPostModel()
        {

            CreateMap<DoctorPostModel, Doctors>().ReverseMap();

        }

    }
}
