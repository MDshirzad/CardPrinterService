using CSharpFunctionalExtensions;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IPrintYMCKO
    {
        Result Print_SingleSide_YMCKO(string printerName);
        Result Print_DoubleSide_YMCKO(string printerName);
    }
}
