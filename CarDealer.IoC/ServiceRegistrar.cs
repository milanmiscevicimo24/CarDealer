using CarDealer.Database.Extensions;
using CarDealer.Services.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CarDealer.IoC
{
    public class ServiceRegistrar : IServiceRegistrar
    {
        public IServiceCollection AddCarDealerServices(IServiceCollection services)
        {
            services.AddCarDealerDatabase();
            services.AddCarDealerCoreServices();

            return services;
        }
    }
}
