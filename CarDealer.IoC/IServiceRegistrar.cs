using Microsoft.Extensions.DependencyInjection;

namespace CarDealer.IoC
{
    public interface IServiceRegistrar
    {
        IServiceCollection AddCarDealerServices(IServiceCollection services);
    }
}
