using CarDealer.Database.Entities;

namespace CarDealer.Database.Repositories.Interfaces
{
    public interface ICarOfferRepository
    {
        public Task<CarOffer> GetCarOfferAsync(string offer);
    }
}
