using Hardware.Printer.Evolis;
using Hardware.Printer.Evolis.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware.Printer
{
    public class PrinterFactory : IPrinterFactory
    {

        //TODO:  IEvolisPeinter is not solid interface in this class  create need to be more flexible for other devices
        public IEvolisPrinter Create(Constatns.PrinterCommunicationType type)
        {
            switch (type)
            {
                case Constatns.PrinterCommunicationType.Usb:
                    return  new USBEvolisPrinter();
                case Constatns.PrinterCommunicationType.Ethernet:
                    break;
                default:
                    break;
            }
      throw new NotImplementedException();
        }
    }
}
