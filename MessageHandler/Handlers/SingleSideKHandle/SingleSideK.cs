﻿using MessageHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Handlers.SingleSideKHandle
{
    internal record SingleSideK(string frontImage) : BasePrinterCommand;
}
