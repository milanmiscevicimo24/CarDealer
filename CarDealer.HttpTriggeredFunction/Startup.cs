using CarDealer.HttpTriggeredFunction;
using CarDealer.IoC;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]
namespace CarDealer.HttpTriggeredFunction
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddCarDealerServices();
        }
    }
}
