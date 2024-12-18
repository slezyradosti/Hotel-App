using Hotel.Domain.Rooms;
namespace Hotel.Domain.Hotels
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public float Rating { get; set; }
        public string ImageUrl { get; set; }
        public IEnumerable<string> DatesOfTravel { get; set; }
        public string BoardBasis { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
    }
}
