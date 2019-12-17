using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace netcore_starter
{
    class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                serviceProvider.GetService<Application>().Run();
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services
                .AddLogging(conf => {
                    conf.ClearProviders();
                    conf.SetMinimumLevel(LogLevel.Trace);
                    conf.AddNLog();
                })

                .AddTransient<Application>()

                ;
        }
    }
}
