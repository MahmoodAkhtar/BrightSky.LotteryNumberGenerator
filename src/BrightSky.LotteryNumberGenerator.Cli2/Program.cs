using Microsoft.Extensions.DependencyInjection;

namespace BrightSky.LotteryNumberGenerator.Cli2
{
    using Core.DependencyInjection;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = ConfigureServices();

            services
                .BuildServiceProvider()
                .GetService<App>()
                .Run();
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddCoreTypeServices();
            services.AddCoreServices();
            services.AddScoped<App>();

            return services;
        }
    }
}