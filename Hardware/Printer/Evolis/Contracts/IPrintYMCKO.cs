using CSharpFunctionalExtensions;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IPrintYMCKO
    {
        Result Print_SingleSide_YMCKO(string printerName, string frontKFilePath, string frontColoredPath, string oFilePath);
        Result Print_DoubleSide_YMCKO(string printerName, string frontColoredFilePath, string frontKFilePath, string backColoredFilePath, string backKFilePath, string OFile);
    }
}
