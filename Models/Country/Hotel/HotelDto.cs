using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mersin.Models.Country.Hotel
{
    public class HotelDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }

        public int CountryId { get; set; }


    }
}