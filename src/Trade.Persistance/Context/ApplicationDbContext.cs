using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Trade.Application.Interfaces.Persistance;
using Trade.Domain.Entities;
using Trade.Persistance.Interceptors;

namespace Trade.Persistance.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly AuditableEntitySaveChangesInterceptor _interceptor;

        public ApplicationDbContext(DbContextOptions options, AuditableEntitySaveChangesInterceptor interceptor) : base(options)
        {
            _interceptor = interceptor;
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(_interceptor);
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
