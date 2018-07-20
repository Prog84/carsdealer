using AutoMapper;
using carsdealer.Controllers.Resources;
using carsdealer.Models;

namespace carsdealer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
    }
}