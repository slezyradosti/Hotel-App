using Hotel.Domain.Hotels;
using System.Text.Json;

namespace Hotel.Infrastructure.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly string _filePath;

        public HotelRepository(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<IEnumerable<Domain.Hotels.Hotel>> GetAllHotelsAsync()
        {
            try
            {
                var jsonData = await File.ReadAllTextAsync(_filePath);
                return JsonSerializer.Deserialize<List<Domain.Hotels.Hotel>>(jsonData);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("HotelRepository GetAllHotels", ex);
                throw ex;
            }
        }
    }
}
