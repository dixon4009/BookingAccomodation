using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingWebAPIDemo.DataModel
{
    public class Hotel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string Location { get; set; }
        public string Rate { get; set; }
    }
}
