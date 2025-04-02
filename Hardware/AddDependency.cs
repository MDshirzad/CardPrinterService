using Hardware.Laser;
using Hardware.Laser.Jcz;
using Hardware.Printer.Contracts;
using Hardware.Printer.Evolis;
using Hardware.Roller;
using Hardware.Roller.F1;
using Microsoft.Extensions.DependencyInjection;

namespace Hardware
{
    public static class DependencyInjection
    {
        public static void AddHardwareServices(this IServiceCollection services)
        {
            services.AddSingleton<IPrinter, USBEvolisPrinter>();
            services.AddSingleton<IRollerHandler, F1ApiHandler>();
            services.AddSingleton<ILaserHandler, JczLaserHandler>();
        }
    }
}
