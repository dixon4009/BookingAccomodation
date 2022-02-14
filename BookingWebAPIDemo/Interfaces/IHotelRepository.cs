using BookingWebAPIDemo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingWebAPIDemo.Interfaces
{
    public class IHotelRepository
    {
        List<Hotel> GetAllHotels();
        Hotel GetByID(int id);
    }

    public class HotelRepository : IHotelRepository
    {
        public List<Hotel> GetAllHotels()
        {
            return new List<Hotel>()
        {
            new Hotel()
            {
                Id = 1,
                HotelName = "Holiday Inn",
                Location = "Dubai",
                Rate = 4000,
            },
            new Hotel()
            {
                Id = 2,
                HotelName = "Indraprastha",
                Location = "Dubai",
                Rate = 3000,
            },
            new Hotel()
            {
               Id = 3,
                HotelName = "Shines",
                Location = "Dubai",
                Rate = 2000,
            }
        };
        }

        public Hotel GetByID(int id)
        {
            var allHotels = GetAllHotels();
            if (allHotels.Where(x => x.Id == id).Any())
            {
                return allHotels.First(x => x.Id == id);
            }
            else return null;
        }
    }
}
