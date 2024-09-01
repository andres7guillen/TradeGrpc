using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Trade.Domain.Entities;

namespace Trade.Persistance.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(o => o.Id);

            builder.Property(o => o.Symbol)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(o => o.Side)
                .HasMaxLength(1)
                .IsRequired();

            builder.Property(o => o.TransactTime)
                .IsRequired();

            builder.Property(o => o.Quanty)
                .HasPrecision(9, 0)
                .IsRequired();

            builder.Property(o => o.Type)
                .HasMaxLength(1)
                .IsRequired();

            builder.Property(o => o.Price)
                .HasPrecision(9, 4)
                .IsRequired();

        }
    }
}
