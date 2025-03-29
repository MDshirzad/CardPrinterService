using CSharpFunctionalExtensions;
using Hardware.Printer.Contracts;
using MessageHandler.Contracts;

namespace MessageHandler.Handlers.SingleSideKHandle
{
    internal class SingleSideKCommandHandler(IUsbPrinter usbPrinter) : ICommandHandler<SingleSideKCommand>
    {
        public async Task<Result<MessageResult>> Handle(SingleSideKCommand request, CancellationToken cancellationToken)
        {
            Result result = default;
            if (request.WriteTrack)
            {
                result = usbPrinter.WriteMagn(request.PrinterName, request.Track1, request.Track2, request.Track3);
            }
            if (result.IsSuccess)
                return new MessageResult("");
            return Result.Failure<MessageResult>(result.Error);
        }
    }
}
