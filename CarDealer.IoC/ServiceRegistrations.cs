using Microsoft.Extensions.DependencyInjection;

namespace CarDealer.IoC
{
    public static class ServiceRegistrations
    {
        public static IServiceRegistrar Implementation { private get; set; } = new ServiceRegistrar();

        public static IServiceCollection AddCarDealerServices(this IServiceCollection services)
        {
            return Implementation.AddCarDealerServices(services);
        }
    }
}
