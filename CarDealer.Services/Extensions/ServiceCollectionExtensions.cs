using CarDealer.Services.Configuration.Mapping.Profiles;
using CarDealer.Services.Services.Implementations;
using CarDealer.Services.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CarDealer.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCarDealerCoreServices(this IServiceCollection services)
        {
            services.AddAutoMapper(new Assembly[]
            {
                typeof(CarBrandProfile).Assembly,
                typeof(CarModelProfile).Assembly,
                typeof(CarOfferProfile).Assembly
            });

            services.AddScoped<ICarService, CarService>();

            return services;
        }
    }
}

