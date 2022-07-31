using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Mersin.Models.Country.Hotel;

namespace Mersin.Models.Country
{
    public class GetCountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }

    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }


}