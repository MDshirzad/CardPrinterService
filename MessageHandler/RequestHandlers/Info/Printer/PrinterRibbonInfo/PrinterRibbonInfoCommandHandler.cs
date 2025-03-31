using CSharpFunctionalExtensions;
using MessageHandler.Contracts;

namespace MessageHandler.RequestHandlers.Info.Printer.PrinterRibbonInfo
{
    internal class PrinterRibbonInfoCommandHandler : ICommandHandler<PrinterRibbonInfoCommand>
    {
        public Task<Result<MessageResult>> Handle(PrinterRibbonInfoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
