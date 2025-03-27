using Hardware.Printer.Evolis.Contracts;

namespace Hardware.Printer.Evolis
{
    internal class USBEvolisPrinter : IEvolisUsbPrinter
    {
        public void ExecutePrinterCommand(string command)
        {
            throw new NotImplementedException();
        }

        public void Print_DoubleSide_K()
        {
            throw new NotImplementedException();
        }

        public void Print_DoubleSide_KO()
        {
            throw new NotImplementedException();
        }

        public void Print_DoubleSide_YMCKO()
        {
            throw new NotImplementedException();
        }

        public void Print_SingleSide_K()
        {
            throw new NotImplementedException();
        }

        public void Print_SingleSide_KO()
        {
            throw new NotImplementedException();
        }

        public void Print_SingleSide_YMCKO()
        {
            throw new NotImplementedException();
        }

        public void WriteMagn(string Track1, string Track2, string Track3)
        {
            throw new NotImplementedException();
        }
    }
}
