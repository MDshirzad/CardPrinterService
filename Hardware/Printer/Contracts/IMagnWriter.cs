using CSharpFunctionalExtensions;

namespace Hardware.Printer.Contracts
{
    public interface IMagnWriter
    {
        Result WriteMagn(string printerName, string Track1, string Track2, string Track3);
        Result EjectCard(string printerName);
    }
}
