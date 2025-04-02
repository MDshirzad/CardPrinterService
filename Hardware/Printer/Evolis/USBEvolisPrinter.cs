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

        public Result Print_SingleSide_K(string printerName,string kFile,string oFile)
        {
            var result = usbPrinter.K_PrintingSingleSide(printerName, kFile, oFile);
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);
        }
        public Result Print_DoubleSide_K(string printerName,string kFileFrontPath,string kFileBackPath)
        {
            var result = usbPrinter.K_PrintingDoubleSide(printerName, kFileFrontPath, kFileBackPath, "k");
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);

        }

        public Result Print_SingleSide_KO(string printerName, string kFileFront, string OFile)
        {
            var result = usbPrinter.KO_PrintingSingleSide(printerName, kFileFront, OFile);
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);
        }
        public Result Print_DoubleSide_KO(string printerName, string kFileFrontPath, string kFileBackPath, string OFile)
        {
            var result = usbPrinter.KO_PrintingDoubleSide(printerName, kFileFrontPath, OFile, kFileBackPath, OFile);
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);
        }

        public Result Print_DoubleSide_YMCKO(string printerName, string frontColoredFilePath, string frontKFilePath, string backColoredFilePath, string backKFilePath,string OFile)
        {
            var result = usbPrinter.YMCKO_PrintingDoubleSide(printerName, "ymcko", frontColoredFilePath, frontKFilePath, OFile, backColoredFilePath, backKFilePath, OFile);
            if (IsSuccess(result))
                return Result.Success();
            return Result.Failure(result);
        }
        public Result Print_SingleSide_YMCKO(string printerName,string frontKFilePath,string frontColoredPath,string oFilePath)
        {
            var result = usbPrinter.YMCKO_PrintingSingleSide(printerName, "ymcko", frontColoredPath, frontKFilePath, oFilePath);
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
