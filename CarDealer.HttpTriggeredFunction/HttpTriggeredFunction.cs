using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using CarDealer.Services.Services.Interfaces;
using System.Web.Http;

namespace CarDealer.HttpTriggeredFunction
{
    public class HttpTriggeredFunction
    {
        private readonly ICarService _carService;

        public HttpTriggeredFunction(ICarService carService)
        {
            _carService = carService;
        }

        [FunctionName("HttpTriggeredFunction")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "Car/Car")] HttpRequest req, ILogger log)
        {
            try
            {
                string brand = req.Query["brand"];
                string model = req.Query["model"];
                string offer = req.Query["offer"];

                var car = await _carService.GetCarAsync(brand, model, offer);

                return new OkObjectResult(car);
            }
            catch (Exception)
            {
                return new InternalServerErrorResult();
            }
        }
    }
}
