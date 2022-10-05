using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Purchases.ApiDotNet6.Application.Mappings;
using Purchases.ApiDotNet6.Application.Services;
using Purchases.ApiDotNet6.Application.Services.Interface;
using Purchases.ApiDotNet6.Domain.Repositories;
using Purchases.ApiDotNet6.Infra.Data.Context;
using Purchases.ApiDotNet6.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purchases.ApiDotNet6.Infra.IoC
{
    public static class DependencyInject
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PurchaseDbContext>(options => 
                                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IPersonRepository, PersonRepository>();
            
            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(DomainToDtoMapping));
            services.AddScoped<IPersonService, PersonService>();

            return services;
        }

    }
}
