using CSharpFunctionalExtensions;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IRibbonPrinter : IPrintK, IPrintKO, IPrintYMCKO
    {
        public Result FlipCard(string printerName);

    }
}
