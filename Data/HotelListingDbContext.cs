using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mersin.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id=1,
                    Name="Jamaica",
                    ShortName="JM"
                },
                new Country
                {
                    Id=2,
                    Name="Bahamas",
                    ShortName="Bs"
                },
                new Country
                {
                    Id=3,
                    Name="Turkey",
                    ShortName="TR"
                }                
                
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id=1,
                    Name="Sandals Resort and Spa",
                    Address="Negril",
                    CountryId=1,
                    Rating=4.5
                },
                new Hotel
                {
                    Id=2,
                    Name="Comfort Suites",
                    Address="Gerofe Town",
                    CountryId=3,
                    Rating=4.3
                },
                new Hotel{
                    Id=3,
                    Name="Grand Palldium",
                    Address="Nassua",
                    CountryId=2,
                    Rating=4
                }
            );
        }
    }
}