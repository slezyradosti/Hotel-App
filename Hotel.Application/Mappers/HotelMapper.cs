using Hotel.Application.DTOs;

namespace Hotel.Application.Mappers
{
    public static class HotelMapper
    {
        public static HotelDto DomainToDto(Domain.Hotels.Hotel hotel)
        {
            return new HotelDto
            {
                Id = hotel.Id,
                Name = hotel.Name,
                BoardBasis = hotel.BoardBasis,
                ImageUrl = hotel.ImageUrl,
                DatesOfTravel = hotel.DatesOfTravel.Select(DateTime.Parse),
                Location = hotel.Location,
                Rating = hotel.Rating,
                Rooms = hotel.Rooms.Select(x => new RoomDto
                {
                    Amount = x.Amount,
                    RoomType = x.RoomType,
                }),
            };
        }

        public static IEnumerable<HotelDto> DomainToDtoEnumaerable(IEnumerable<Domain.Hotels.Hotel> hotel)
        {
            return hotel.Select(x => new HotelDto
            {
                Id = x.Id,
                Name = x.Name,
                BoardBasis = x.BoardBasis,
                ImageUrl = x.ImageUrl,
                DatesOfTravel = x.DatesOfTravel.Select(DateTime.Parse),
                Location = x.Location,
                Rating = x.Rating,
                Rooms = x.Rooms.Select(h => new RoomDto
                {
                    Amount = h.Amount,
                    RoomType = h.RoomType,
                }),
            });
        }
    }
}
