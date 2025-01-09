using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeStation.Order.Application.Services
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationService(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            services.AddMediatR(typeof(ServiceRegistiration).Assembly);

            // services.AddMediatR(cfg =>
            //     cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly)
            // );
        }
    }
}
