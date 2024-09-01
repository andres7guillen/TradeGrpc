using Trade.Domain.Commons;

namespace Trade.Domain.Events
{
    public class OrderCanceledEvent : BaseEvent
    {
        public Guid Id { get; set; }
    }
}
