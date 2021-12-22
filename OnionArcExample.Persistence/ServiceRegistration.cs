using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArcExample.Application.Interfaces.Repositories;
using OnionArcExample.Application.Interfaces.UnitOfWork;
using OnionArcExample.Persistence.Context;
using OnionArcExample.Persistence.Repositories;
using OnionArcExample.Persistence.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection, IConfiguration configuration = null)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration?.GetConnectionString("SQLConnection")));

            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
