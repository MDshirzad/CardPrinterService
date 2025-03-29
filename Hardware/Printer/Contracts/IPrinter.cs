using CSharpFunctionalExtensions;
using Hardware.Printer.Evolis.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware.Printer.Contracts
{
    public interface IPrinter : IRibbonPrinter, IMagnWriter
    {
        public Result<string> ExecutePrinterCommand(string printerName, string command);
    }
}
