using Hardware.Printer.Contracts;
using Hardware.Printer.Evolis;
using Microsoft.Extensions.DependencyInjection;

namespace Hardware
{
    public static class DependencyInjection
    {
        public static void AddHardwareServices(this IServiceCollection services)
        {
            services.AddSingleton<IPrinter, USBEvolisPrinter>();

        }
    }
}
