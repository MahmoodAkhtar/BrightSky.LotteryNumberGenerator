using Microsoft.Extensions.DependencyInjection;

namespace BrightSky.LotteryNumberGenerator.Core.DependencyInjection
{
    using Contracts;
    using Types;

    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreTypeServices(this IServiceCollection services)
        {
            services.AddTransient<MinLotteryNumber>();
            services.AddTransient<MaxLotteryNumber>();
            services.AddTransient<LotteryLength>();
            services.AddTransient<LotteryDefinition>();

            return services;
        }

        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<ILotteryNumberGenerator, LotteryNumberGenerator>();
            services.AddScoped<ILottery, Lottery>();

            return services;
        }
    }
}