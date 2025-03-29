using CSharpFunctionalExtensions;
using Hardware.Printer.Contracts;
using Hardware.Printer.Evolis.Contracts;

namespace Hardware.Printer.Evolis
{
    internal class USBEvolisPrinter : IEvolisPrinter, IPrinter
    {
        EVOLIS_CLASS.USB usbPrinter = new EVOLIS_CLASS.USB();
        public Result<string> ExecutePrinterCommand(string printerName, string command)
        {
            return usbPrinter.RunEvolisCommand(printerName, command);
        }

        public Result Print_DoubleSide_K(string printerName)
        {
            var result = usbPrinter.K_PrintingDoubleSide(printerName, "", "", "");
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);

        }

        public Result Print_DoubleSide_KO(string printerName)
        {
            var result = usbPrinter.KO_PrintingDoubleSide(printerName, "", "", "", "");
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);
        }

        public Result Print_DoubleSide_YMCKO(string printerName)
        {
            var result = usbPrinter.YMCKO_PrintingDoubleSide(printerName, "", "", "", "", "", "", "");
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);
        }

        public Result Print_SingleSide_K(string printerName)
        {
            var result = usbPrinter.KO_PrintingSingleSide(printerName, "", "");
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);
        }

        public Result Print_SingleSide_KO(string printerName)
        {
            var result = usbPrinter.KO_PrintingSingleSide(printerName, "", "");
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);
        }

        public Result Print_SingleSide_YMCKO(string printerName)
        {
            var result = usbPrinter.YMCKO_PrintingSingleSide(printerName, "", "", "", "");
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);
        }

        public Result WriteMagn(string PrinterName, string Track1, string Track2, string Track3)
        {
            var result = usbPrinter.RunEvolisCommand(PrinterName, "Dm;1;" + Track1.ToUpper());
            if (IsSuccess(result))
            {
                result = usbPrinter.RunEvolisCommand(PrinterName, "Dm;2;" + Track2.ToUpper());
                if (IsSuccess(result))
                {
                    result = usbPrinter.RunEvolisCommand(PrinterName, "Dm;3;" + Track3.ToUpper());
                    if (IsSuccess(result))
                    {
                        result = usbPrinter.RunEvolisCommand(PrinterName, "Smw");
                        if (IsSuccess(result))
                        {
                            return Result.Success();
                        }
                    }
                }
            }
            return Result.Failure(result);
        }


        private bool IsSuccess(string result) => result.Equals("ok", StringComparison.CurrentCultureIgnoreCase) || result.Equals("done", StringComparison.CurrentCultureIgnoreCase) ? true : false;
    }
}
