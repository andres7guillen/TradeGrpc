using Trade.Domain.Commons;
using Trade.Domain.Enums;

namespace Trade.Domain.Events
{
    public class OrderUpdatedEvent : BaseEvent
    {
        public Guid Id { get; set; }
        public int Quanty { get; set; }
        public OrderType Type { get; set; }
        public decimal Price { get; set; }
        public string Text { get; set; }
    }
}
