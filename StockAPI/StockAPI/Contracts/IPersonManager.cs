using StockAPI.Data;
using StockAPI.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockAPI.Contracts
{
    public interface IPersonManager : IRepository<Person>
    {
        Task<(IEnumerable<Person> Persons, Pagination Pagination)> GetPersonsAsync(UrlQueryParameters urlQueryParameters);

        //Add more class specific methods here when neccessary
    }
}
