using MediatR;
using MessageHandler.Contracts;

namespace MessageHandler.RequestHandlers.Info.Printer.ConnectedPrinters
{
    internal record ConnectedPrintersCommand : NonJsonRequest;

}
