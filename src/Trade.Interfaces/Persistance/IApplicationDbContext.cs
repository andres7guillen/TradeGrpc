using Microsoft.EntityFrameworkCore;
using Trade.Domain.Entities;

namespace Trade.Application.Interfaces.Persistance
{
    public interface IApplicationDbContext
    {
        DbSet<Order> Orders { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
