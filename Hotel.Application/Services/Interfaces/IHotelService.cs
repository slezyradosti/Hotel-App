using Hotel.Application.DTOs;

namespace Hotel.Application.Services.Interfaces
{
    public interface IHotelService
    {
        Task<IEnumerable<HotelDto>> GetAllHotelsAsync();
        Task<HotelDto?> GetHotelById(int hotelId);
    }
}
