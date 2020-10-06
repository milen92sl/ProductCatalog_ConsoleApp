using System;
using ProductCatalog.Utils;
using Microsoft.Extensions.DependencyInjection;
namespace ProductCatalog
{
    public class Program
    {
         static void Main(string[] args)
        {
            var serviceProvider = DependencyResolver.GetServiceProvider();
            var app = serviceProvider.GetService<Application>();

            using (serviceProvider.CreateScope())
            {
                app.Run(args);
            }
        }

    }
}
