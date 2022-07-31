using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Mersin.Data;
using Mersin.Models.Country;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mersin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly HotelListingDbContext _context;
        private readonly IMapper _mapper;

        public CountriesController(HotelListingDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCountryDto>>> GetCountries()
        {
            var countries=await _context.Countries.ToListAsync();
             var records=_mapper.Map<List<GetCountryDto>>(countries);
             return Ok(records);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CountryDto>> GetCountry(int id)
        {
            var country = await _context.Countries.Include(q=>q.Hotels)
            .FirstOrDefaultAsync(q=>q.Id==id);

            if (country == null)
            {
                return NotFound();
            }
            var countryDto=_mapper.Map<CountryDto>(country);
            return Ok(country);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, Country country)
        {
            if (id != country.Id)
            {
                return BadRequest();
            }
            _context.Entry(country).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!CountryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();

        }

        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(CreateCountryDto createCountryDto)
        {
            var countryold=new Country
            {
                Name=createCountryDto.Name,
                ShortName=createCountryDto.ShortName,
            };

            var country=_mapper.Map<Country>(createCountryDto);

            _context.Countries.Add(country);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if(country==null)
            {
                return NotFound();
            }

            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool CountryExists(int id)
        {
            return _context.Countries.Any(e=>e.Id==id);
        }


    }
}