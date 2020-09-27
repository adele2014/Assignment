using StockAPI.Data;
using StockAPI.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockAPI.Contracts
{
    public interface IPurchasedStock : IRepository<PurchasedStock>
    {
        Task<(IEnumerable<PurchasedStock> PurchasedStocks, Pagination Pagination)> GetPurchasesAsync(UrlQueryParameters urlQueryParameters);

        //Add more class specific methods here when neccessary
    }
}
