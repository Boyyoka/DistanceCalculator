using System;
using System.Threading.Tasks;
using DistanceCalculator.Helpers;
using DistanceCalculator.Models;
using DistanceCalculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace DistanceCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistanceController : ControllerBase
    {
        private readonly ICTeleportServices _services;

        public DistanceController(ICTeleportServices services)
        {
            _services = services;
        }

        // POST api/distance/calculate
        [HttpPost]
        [Route("Calculate")]
        public async Task<IActionResult> CalculateDistance(Points points)
        {
            try
            {
                var Airport1 = await _services.GetAirportData(points.PointA);
                var Airport2 = await _services.GetAirportData(points.PointB);

                if (Airport1 == null || Airport2 == null)
                {
                    return NotFound("Airport not found");
                }
                else
                {
                    int distance = CalcHelper
                        .CalculateDistanceInMiles(Airport1.Latitude, Airport2.Latitude,
                            Airport2.Longitude, Airport2.Longitude);

                    return Ok(distance);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
