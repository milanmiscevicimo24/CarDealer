using AutoMapper;
using CarDealer.Database.Entities;
using CarDealer.Services.Types;

namespace CarDealer.Services.Configuration.Mapping.Profiles
{
    public class CarOfferProfile : Profile
    {
        public CarOfferProfile()
        {
            CreateMap<CarOfferDTO, CarOffer>();
            CreateMap<CarOffer, CarOfferDTO>();
        }
    }
}
