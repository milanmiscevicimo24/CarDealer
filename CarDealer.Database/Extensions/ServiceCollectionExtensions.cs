using CarDealer.Database.Repositories.Implementations;
using CarDealer.Database.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CarDealer.Database.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCarDealerDatabase(this IServiceCollection services)
        {
            services.AddScoped<ICarBrandRepository, CarBrandRepository>();
            services.AddScoped<ICarModelRepository, CarModelRepository>();
            services.AddScoped<ICarOfferRepository, CarOfferRepository>();

            return services;
        }
    }
}
