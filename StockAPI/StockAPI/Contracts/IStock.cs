using StockAPI.Data;
using StockAPI.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockAPI.Contracts
{
    public interface IStock : IRepository<Stock>
    {
        Task<(IEnumerable<Stock> Stocks, Pagination Pagination)> GetPurchasesAsync(UrlQueryParameters urlQueryParameters);

        //Add more class specific methods here when neccessary
    }
}
