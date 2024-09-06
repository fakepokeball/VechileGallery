using Application.Requests.Car;
using Application.Responses.Car;
using Application.Services.Abstract;
using Core.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
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

        [HttpPost]
        public async Task<IActionResult> CreateCar([FromBody] CreateCarRequest request)
        {
            var response = await _carService.AddCarAsync(request);
            return CreatedAtAction(nameof(GetCarById), new { id = response.Id }, response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarById([FromRoute] Guid id)
        {
            var request = new GetCarByIdRequest { Id = id };
            var response = await _carService.GetCarByIdAsync(request);
            return Ok(response);
        }

        [HttpGet("color")]
        public async Task<IActionResult> GetCarsByColor([FromQuery] Color? color)
        {
            var request = new GetCarListRequest { FilterByColor = color };
            var response = await _carService.GetCarsByColorAsync(request);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCar([FromRoute] Guid id, [FromBody] UpdateCarRequest request)
        {
            request.Id = id;
            var response = await _carService.UpdateCarAsync(request);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar([FromRoute] Guid id)
        {
            var request = new DeleteCarRequest { Id = id };
            var response = await _carService.DeleteCarAsync(request);
            return Ok(response);
        }

        [HttpPost("cars/{id}/headlights")]
        public async Task<IActionResult> ToggleHeadlights([FromBody] ToggleHeadlightsRequest request)
        {
            // burdan devam et
            return null;
        }
    }
}
