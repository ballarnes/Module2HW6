using Microsoft.Extensions.DependencyInjection;
using Module2HW6.Providers.Abstractions;
using Module2HW6.Providers;
using Module2HW6.Services.Abstractions;
using Module2HW6.Services;

namespace Module2HW6
{
    public class Starter
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                            .AddSingleton<ICarProvider, CarProvider>()
                            .AddSingleton<ITaxiStationProvider, TaxiStationProvider>()
                            .AddTransient<ITaxiStationService, TaxiStationService>()
                            .AddTransient<IPriceService, PriceService>()
                            .AddTransient<ISortService, SortService>()
                            .AddTransient<App>()
                            .BuildServiceProvider();

            var appStart = serviceProvider.GetService<App>();
            appStart.Start();
        }
    }
}
