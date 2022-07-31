using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mersin.Models.Country.Hotel;

namespace Mersin.Models.Country
{
    public class CountryDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public List<HotelDto> Hotels { get; set; }
    
    }
}