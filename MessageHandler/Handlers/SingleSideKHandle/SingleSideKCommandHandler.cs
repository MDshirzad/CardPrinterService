using CSharpFunctionalExtensions;
using Hardware.Printer.Contracts;
using MessageHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Handlers.SingleSideKHandle
{
    internal class SingleSideKCommandHandler (IUsbPrinter usbPrinter): ICommandHandler<SingleSideK>
    {
        public async Task<Result<MessageResult>> Handle(SingleSideK request, CancellationToken cancellationToken)
        {
            Result result=default;
            if (request.WriteTrack)
            {
              result =     usbPrinter.WriteMagn(request.PrinterName, request.Track1,request.Track2,request.Track3);
            }
            if(result.IsSuccess)
                  return new MessageResult("");
            return Result.Failure<MessageResult>(result.Error);
        }
    }
}
