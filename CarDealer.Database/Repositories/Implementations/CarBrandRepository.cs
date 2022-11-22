using CarDealer.Database.Entities;
using CarDealer.Database.Repositories.Interfaces;
using MongoDB.Driver;

namespace CarDealer.Database.Repositories.Implementations
{
    public class CarBrandRepository : ICarBrandRepository
    {
        private readonly IMongoCollection<CarBrand> _carBrandsCollection;

        public CarBrandRepository()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var mongoDatabase = mongoClient.GetDatabase("CarDealer");
            _carBrandsCollection = mongoDatabase.GetCollection<CarBrand>("Brands");
        }

        public async Task<CarBrand> GetCarBrandAsync(string manufacturer)
        {
            var carBrand = await _carBrandsCollection.Find(x => x.Manufacturer == manufacturer).FirstOrDefaultAsync();

            return carBrand;
        }
    }
}
