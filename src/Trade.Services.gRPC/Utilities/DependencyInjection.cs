using System.Reflection;

namespace Trade.Services.gRPC.Utilities
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterPresentationServices(this IServiceCollection services) 
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
