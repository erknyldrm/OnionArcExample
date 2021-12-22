using Microsoft.Extensions.DependencyInjection;
using OnionArcExample.Application.Interfaces.Services;

namespace OnionArcExample.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEmailService, EmailService>();
        }
    }
}
