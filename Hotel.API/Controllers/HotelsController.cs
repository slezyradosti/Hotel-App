using Hotel.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHotels()
        {
            try
            {
                var hotels = await _hotelService.GetAllHotelsAsync();

                if (hotels is null) 
                {
                    return NotFound("No hotels found");
                }

                return Ok(hotels);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { ex.Message });
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHotelById(int id)
        {
            if (id <= 0) 
            {
                return BadRequest(new { Message = "ID must be a positive integer" });
            }

            try
            {
                var hotel = await _hotelService.GetHotelById(id);

                if (hotel is null)
                {
                    return NotFound("Hotel not found");
                }

                return Ok(hotel);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { ex.Message });
            }
        }
    }
}
