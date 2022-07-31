using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mersin.Models.Country
{
    public class CreateCountryDto
    {
        [Required]
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}