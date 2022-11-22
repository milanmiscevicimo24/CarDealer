using CarDealer.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarDealer.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        [Route("Car")]
        public async Task<IActionResult> GetCar(string brand, string model, string offer)
        {
            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(offer))
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Please provide details: brand, model and offer.");
            }

            var car = await _carService.GetCarAsync(brand, model, offer);

            if (car == null)
            {
                return NotFound("Car not found.");
            }
            else
            {
                return Ok(car);
            }
        }
    }
}
