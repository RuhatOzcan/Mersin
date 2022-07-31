using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mersin.Contracts;
using Mersin.Data;

namespace Mersin.Repository
{
    public class CountriesRepository:GenericRepository<Country>,ICountriesRepository
    {
        private readonly HotelListingDbContext _context;

        public CountriesRepository(HotelListingDbContext context):base(context)
        {
            _context = context;
        }

        public async Task<Country> GetDatails(int? id)
        {
            return await _context.Countries.Include(q=>q.Hotels)
            .FirstOrDefaultAsync(q=>q.Id==id);
        }
    }
}