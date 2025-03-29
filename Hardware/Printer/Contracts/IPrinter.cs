using CSharpFunctionalExtensions;
using Hardware.Printer.Evolis.Contracts;

namespace Hardware.Printer.Contracts
{
    public interface IPrinter : IRibbonPrinter, IMagnWriter
    {
        public Result<string> ExecutePrinterCommand(string printerName, string command);
    }
}
