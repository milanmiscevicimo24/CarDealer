using CarDealer.Database.Entities;

namespace CarDealer.Database.Repositories.Interfaces
{
    public interface ICarModelRepository
    {
        public Task<CarModel> GetCarModelAsync(string model);
    }
}
