using Hotel.Application.DTOs;
using Hotel.Application.Mappers;
using Hotel.Application.Services.Interfaces;
using Hotel.Domain.Hotels;

namespace Hotel.Application.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<IEnumerable<HotelDto>> GetAllHotelsAsync()
        {
            var hotels = await _hotelRepository.GetAllHotelsAsync();

            return HotelMapper.DomainToDtoEnumaerable(hotels);
        }

        public async Task<HotelDto?> GetHotelById(int hotelId)
        {
            var hotel = await _hotelRepository.GetHotelByIdAsync(hotelId);

            if (hotel is null)
            {
                return null;
            }

            return HotelMapper.DomainToDto(hotel);
        }
    }
}
