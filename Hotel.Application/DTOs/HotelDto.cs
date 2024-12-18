namespace Hotel.Application.DTOs
{
    public class HotelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public float Rating { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<DateOnly> DatesOfTravel { get; set; }
        public string BoardBasis { get; set; }
        public IEnumerable<RoomDto> Rooms { get; set; }
    }
}
