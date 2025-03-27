
using Hardware.Printer.Evolis.Contracts;
using static Hardware.Constatns;

namespace Hardware.Printer
{
    public interface IPrinterFactory
    {
        IEvolisPrinter Create(PrinterCommunicationType type);

    }
}
