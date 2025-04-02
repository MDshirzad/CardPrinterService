using CSharpFunctionalExtensions;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IPrintKO
    {
        Result Print_SingleSide_KO(string printerName, string kFileFront, string OFile);
        Result Print_DoubleSide_KO(string printerName, string kFileFrontPath, string kFileBackPath, string OFile);
    }
}
