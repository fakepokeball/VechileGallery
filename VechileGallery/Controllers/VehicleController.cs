using Application.Services.Abstract;
using Core.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclesController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehiclesController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet("cars")]
        public async Task<IActionResult> GetCarsByColor([FromQuery] Color? color)
        {
            var cars = await _vehicleService.GetCarsByColorAsync(color);
            return Ok(cars);
        }

        [HttpGet("buses")]
        public async Task<IActionResult> GetBusesByColor([FromQuery] Color? color)
        {
            var buses = await _vehicleService.GetBusesByColorAsync(color);
            return Ok(buses);
        }

        [HttpGet("boats")]
        public async Task<IActionResult> GetBoatsByColor([FromQuery] Color? color)
        {
            var boats = await _vehicleService.GetBoatsByColorAsync(color);
            return Ok(boats);
        }
    }
}
