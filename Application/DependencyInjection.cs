using Application.Services;
using Application.Services.Operators;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddSingleton<BeelineOperatorService>();
            services.AddSingleton<KcellOperatorService>();
            services.AddSingleton<Tele2OperatorService>();

            services.AddSingleton<TopUpBalanceService>();
            //services.AddSingleton<ILoggerFactory, LoggerFactory>();
            //services.AddSingleton(typeof(ILogger<>), typeof(Logger<>));
        }
    }
}
