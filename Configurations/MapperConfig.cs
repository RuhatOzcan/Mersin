using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Mersin.Data;
using Mersin.Models.Country;
using Mersin.Models.Country.Hotel;

namespace Mersin.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Country,CreateCountryDto>().ReverseMap();
            CreateMap<Country,GetCountryDto>().ReverseMap();
            CreateMap<Country,CountryDto>().ReverseMap();
            CreateMap<Country,UpdateCountryDto>().ReverseMap();
            
            CreateMap<Hotel,HotelDto>().ReverseMap();
            CreateMap<Hotel,CreateHotelDto>().ReverseMap();
        }
    }
}