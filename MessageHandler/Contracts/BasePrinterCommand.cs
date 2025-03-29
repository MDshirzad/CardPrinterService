using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Contracts
{
    internal abstract record BasePrinterCommand : BaseCommand{
        public string PrinterName { get; set; } =string.Empty;
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public string Track3 { get; set; }
        public bool WriteTrack { get; set; } = true;
    }
   
}
