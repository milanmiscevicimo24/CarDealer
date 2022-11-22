using CarDealer.Database.Entities;
using CarDealer.Database.Repositories.Interfaces;
using MongoDB.Driver;

namespace CarDealer.Database.Repositories.Implementations
{
    public class CarOfferRepository : ICarOfferRepository
    {
        private readonly IMongoCollection<CarOffer> _carOffersCollection;

        public CarOfferRepository()
        {
            var mongoClient = new MongoClient("mongodb://localhost:27017");
            var mongoDatabase = mongoClient.GetDatabase("CarDealer");
            _carOffersCollection = mongoDatabase.GetCollection<CarOffer>("Offers");
        }

        public async Task<CarOffer> GetCarOfferAsync(string offer)
        {
            var carOffer = await _carOffersCollection.Find(x => x.Offer == offer).FirstOrDefaultAsync();

            return carOffer;
        }
    }
}
