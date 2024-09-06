using Trade.Domain.Commons;
using Trade.Domain.Enums;

namespace Trade.Domain.Entities
{
    public class Order : BaseAuditableEntity
    {
        public Order(){}
        private Order(Guid id, string symbol, OrderSide side, int quanty,DateTime transactTime, OrderType type, decimal price, string currency, string text, DateTime created, string createdBy)
        {
            Id = id;
            Symbol = symbol;
            Side = side;
            Type = type;
            Price = price;
            Quanty = quanty;
            TransactTime = transactTime;
            Currency = currency;
            Text = text;
            Created = created;
            CreatedBy = createdBy;
        }
        public string Symbol { get; set; }
        public OrderSide Side { get; set; }
        public DateTime TransactTime { get; set; }
        public int Quanty { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string? Text { get; set; }

        public static Order Build(string withSymbol, OrderSide withSide,int withQuanty, OrderType withType, decimal withPrice, string withCurrency, string withText, string withCreatedBy) 
        {
            return new Order(Guid.NewGuid(), withSymbol, withSide, withQuanty, DateTime.Now, withType, withPrice, withCurrency, withText, DateTime.Now,withCreatedBy);
        }

    }
}
