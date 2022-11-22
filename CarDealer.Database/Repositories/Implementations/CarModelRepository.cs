using CarDealer.Database.Entities;
using CarDealer.Database.Repositories.Interfaces;
using MongoDB.Driver;

namespace CarDealer.Database.Repositories.Implementations
{
    public class CarModelRepository : ICarModelRepository
    {
        private readonly IMongoCollection<CarModel> _carModelsCollection;

        public CarModelRepository()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var mongoDatabase = mongoClient.GetDatabase("CarDealer");
            _carModelsCollection = mongoDatabase.GetCollection<CarModel>("Models");
        }

        public async Task<CarModel> GetCarModelAsync(string model)
        {
            var carModel = await _carModelsCollection.Find(x => x.Model == model).FirstOrDefaultAsync();

            return carModel;
        }
    }
}
