
using Infrastructure_maintenance_system.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Infrastructure_maintenance_system
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            var servicesProvider = services.BuildServiceProvider();
            
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IRoutingService, RoutingService>();
            serviceCollection.AddTransient<IClientService, ClientService>();
            serviceCollection.AddTransient<IProcessingService, ProcessingService>();
            serviceCollection.AddTransient<IVerificationService, VerificationService>();
        }
    }
}
