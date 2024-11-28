using CarRentalApp.Application.InterfacesService;
using CarRentalApp.Application.Models.Cars;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalApp.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("available")]
        public async Task<IActionResult> GetAvailableCars()
        {
            var cars = await _carService.GetAvailableCarsAsync();
            return Ok(cars);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            var car = await _carService.GetCarByIdAsync(id);
            if (car == null) return NotFound();
            return Ok(car);
        }

        [HttpPost]
        public async Task<IActionResult> AddCar(CarCreateDto carCreateDto)
        {
            await _carService.AddCarAsync(carCreateDto);
            return CreatedAtAction(nameof(GetCarById), new { id = carCreateDto.Brand }, carCreateDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCar(int id, CarUpdateDto carUpdateDto)
        {
            await _carService.UpdateCarAsync(id, carUpdateDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            await _carService.DeleteCarAsync(id);
            return NoContent();
        }
    }
}
