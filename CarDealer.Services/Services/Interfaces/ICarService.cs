using CarDealer.Services.Types;

namespace CarDealer.Services.Services.Interfaces
{
    public interface ICarService
    {
        public Task<CarDTO> GetCarAsync(string brand, string model, string offer);
    }
}
