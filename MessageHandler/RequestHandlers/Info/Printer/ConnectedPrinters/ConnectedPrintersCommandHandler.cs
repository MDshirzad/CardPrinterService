using CSharpFunctionalExtensions;
using MessageHandler.Contracts;

namespace MessageHandler.RequestHandlers.Info.Printer.ConnectedPrinters
{
    internal class ConnectedPrintersCommandHandler : ICommandHandler<ConnectedPrintersCommand>
    {
        public Task<Result<MessageResult>> Handle(ConnectedPrintersCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
