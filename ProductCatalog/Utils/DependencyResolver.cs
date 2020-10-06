using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalog.Core.Contracts;
using ProductCatalog.Core.Services;
using ProductCatalog.Pages;
using ProgramCatalog.Infrastructure.Data;
using ProgramCatalog.Infrastructure.Data.Common;

namespace ProductCatalog.Utils
{
    public static class DependencyResolver
    {
        public static IServiceProvider GetServiceProvider()
        {
            var services = new ServiceCollection();

            services.AddSingleton<IRepository, Repository>();
            services.AddSingleton<Application>();
            services.AddScoped<Menu>();
            services.AddScoped<ProductPage>();
            services.AddScoped<IProductService, ProductService>();

            services.AddDbContext<ApplicationDBContext>(o => o.UseSqlServer("sadasdadasddsad"));

            return services.BuildServiceProvider();
        }
    }
}
