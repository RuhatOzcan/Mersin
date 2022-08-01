using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mersin.Contracts;
using Mersin.Data;

namespace Mersin.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}