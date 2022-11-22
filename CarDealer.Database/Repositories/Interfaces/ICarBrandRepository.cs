using CarDealer.Database.Entities;

namespace CarDealer.Database.Repositories.Interfaces
{
    public interface ICarBrandRepository
    {
        public Task<CarBrand> GetCarBrandAsync(string manufacturer);
    }
}
