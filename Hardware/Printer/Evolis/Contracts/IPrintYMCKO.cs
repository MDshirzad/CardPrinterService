using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware.Printer.Evolis.Contracts
{
    public interface IPrintYMCKO
    {
        void Print_SingleSide_YMCKO();
        void Print_DoubleSide_YMCKO();
    }
}
