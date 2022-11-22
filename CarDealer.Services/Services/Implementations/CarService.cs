using AutoMapper;
using CarDealer.Database.Repositories.Interfaces;
using CarDealer.Services.Services.Interfaces;
using CarDealer.Services.Types;

namespace CarDealer.Services.Services.Implementations
{
    public class CarService : ICarService
    {
        private readonly IMapper _mapper;
        private readonly ICarBrandRepository _carBrandRepository;
        private readonly ICarModelRepository _carModelRepository;
        private readonly ICarOfferRepository _carOfferRepository;

        public CarService(IMapper mapper, ICarBrandRepository carBrandRepository, ICarModelRepository carModelRepository, ICarOfferRepository carOfferRepository)
        {
            _mapper = mapper;
            _carBrandRepository = carBrandRepository;
            _carModelRepository = carModelRepository;
            _carOfferRepository = carOfferRepository;
        }

        public async Task<CarDTO> GetCarAsync(string brand, string model, string offer)
        {
            var carBrand = await _carBrandRepository.GetCarBrandAsync(brand);
            var carModel = await _carModelRepository.GetCarModelAsync(model);
            var carOffer = await _carOfferRepository.GetCarOfferAsync(offer);

            var result = new CarDTO()
            {
                Brand = _mapper.Map<CarBrandDTO>(carBrand),
                Model = _mapper.Map<CarModelDTO>(carModel),
                Offer = _mapper.Map<CarOfferDTO>(carOffer)
            };

            return result;
        }
    }
}
