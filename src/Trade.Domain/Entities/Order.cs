using Trade.Domain.Commons;
using Trade.Domain.Enums;

namespace Trade.Domain.Entities
{
    public class Order : BaseAuditableEntity
    {
        public string Symbol { get; set; }
        public OrderSide Side { get; set; }
        public DateTime TransactTime { get; set; }
        public int Quanty { get; set; }
        public OrderType Type { get; set; }
    }
}
