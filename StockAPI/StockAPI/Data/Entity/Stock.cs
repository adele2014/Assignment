using System;

namespace StockAPI.Data.Entity
{
    public class Stock : EntityBase
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string LastName { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime Closing { get; set; }
        public decimal AmountPerShare { get; set; }
        public string CustomerId { get; set; }
    }
}
