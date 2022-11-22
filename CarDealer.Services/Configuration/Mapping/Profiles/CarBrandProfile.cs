using AutoMapper;
using CarDealer.Database.Entities;
using CarDealer.Services.Types;

namespace CarDealer.Services.Configuration.Mapping.Profiles
{
    public class CarBrandProfile : Profile
    {
        public CarBrandProfile()
        {
            CreateMap<CarBrandDTO, CarBrand>();
            CreateMap<CarBrand, CarBrandDTO>();
        }
    }
}
