using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Mersin.Models.Country.Hotel;

namespace Mersin.Models.Country
{
    public class GetCountryDto:BaseCountryDto
    {
        public int Id { get; set; }
      
    }



}