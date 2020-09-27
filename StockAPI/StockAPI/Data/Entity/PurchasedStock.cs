using System;

namespace StockAPI.Data.Entity
{
    public class PurchasedStock : EntityBase
    {
        public long Id { get; set; }
        public string StockCode { get; set; }
        public Int64 NoofShares { get; set; }
        public Person Customer { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
