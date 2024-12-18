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
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            try
            {
                var jsonData = await File.ReadAllTextAsync(_filePath);
                return JsonSerializer.Deserialize<IEnumerable<Domain.Hotels.Hotel>>(jsonData, options);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("HotelRepository GetAllHotels", ex.Message);
                throw ex;
            }
        }

        public async Task<Domain.Hotels.Hotel?> GetHotelByIdAsync(int hotelId)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            try
            {
                var jsonData = await File.ReadAllTextAsync(_filePath);
                var hotels = JsonSerializer.Deserialize<IEnumerable<Domain.Hotels.Hotel>>(jsonData, options);
                return hotels?.FirstOrDefault(x => x.Id == hotelId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("HotelRepository GetHotelById", ex.Message);
                throw ex;
            }
        }
    }
}
