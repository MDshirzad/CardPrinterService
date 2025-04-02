using CSharpFunctionalExtensions;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IPrintK
    {
        Result Print_DoubleSide_K(string printerName, string kFileFrontPath, string kFileBackPath);

    }
}
