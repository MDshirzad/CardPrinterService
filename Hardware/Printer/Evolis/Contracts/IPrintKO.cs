using CSharpFunctionalExtensions;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IPrintKO
    {
        Result Print_SingleSide_KO(string printerName);
        Result Print_DoubleSide_KO(string printerName);
    }
}
