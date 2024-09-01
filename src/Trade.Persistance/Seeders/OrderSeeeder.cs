using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trade.Domain.Entities;
using Trade.Domain.Enums;

namespace Trade.Persistance.Seeders
{
    public class OrderSeeeder : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                Order.Build("META", OrderSide.BUY, 1000, OrderType.LIMIT, 522.99M),
                Order.Build("MICROSOFT", OrderSide.BUY, 300, OrderType.LIMIT, 424.30M),
                Order.Build("AMAZON", OrderSide.SELL, 400, OrderType.MARKET, 0),
                Order.Build("TESLA", OrderSide.SELL, 800, OrderType.MARKET, 0));
        }
    }
}
