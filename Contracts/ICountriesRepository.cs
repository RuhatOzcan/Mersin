using Mersin.Data;

namespace Mersin.Contracts
{
    public interface ICountriesRepository:IGenericRepository<Country>
    {
        Task<Country> GetDatails(int id);
    }
}