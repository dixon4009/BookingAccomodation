using System;
using Xunit;
using BookingAccomodation.Models;

namespace BookingAccomodationTest
{
    public class BookingUnitTest
    {
        [Fact]
        public void CanChangeBookingUnitTestName()
        {
            var hotel = new Hotel
            {
                HotelName = "test",
                Location = "sydney",
                Rate = 1000

            };

            hotel.HotelName = "New Name";

            Assert.Equal("New Name", hotel.HotelName);


        }

        [Fact]
        public void CanChangeBookingUnitTestRate()
        {
            var hotel = new Hotel
            {
                HotelName = "test",
                Location = "sydney",
                Rate = 1000

            };

            hotel.Rate = 3000;

            Assert.Equal(3000, hotel.Rate);


        }
    }
}
