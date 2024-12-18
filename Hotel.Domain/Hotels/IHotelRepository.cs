namespace Hotel.Domain.Hotels
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotel>> GetAllHotelsAsync();
    }
}
