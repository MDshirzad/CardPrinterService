namespace Hardware.Printer.Evolis.Contracts
{
    public interface IEvolisPrinter : IRibbonPrinter, IMagnWriter
    {

        public void ExecutePrinterCommand(string command);
    }
}
