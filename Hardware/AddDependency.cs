
using Hardware.Printer;
using Microsoft.Extensions.DependencyInjection;

namespace Hardware
{
    public static class DependencyInjection
    {
        public static void AddHardwareServices(this IServiceCollection services)
        {
            services.AddSingleton<IPrinterFactory, PrinterFactory>();

        }
    }
}
