using CSharpFunctionalExtensions;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IPrintK
    {
        Result Print_SingleSide_K(string printerName);
        Result Print_DoubleSide_K(string printerName);
    }
}
