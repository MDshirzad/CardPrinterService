using CSharpFunctionalExtensions;
using Hardware.Printer.Contracts;
using MessageHandler.Contracts;
using MessageHandler.Messages.Api.Response;
using SharedKernel.Exceptions.Device;

namespace MessageHandler.Handlers
{
    internal abstract class BasePrintCommandHandler<T> : ICommandHandler<T> where T : BasePrinterCommand
    {
        IPrinter printer;
        protected BasePrintCommandHandler(IPrinter printer)
        {
            this.printer = printer;
        }

        public abstract   Task<Result<MessageResult>> Handle(T request, CancellationToken cancellationToken);
        protected virtual void WriteMagnIfNeeded(T request, CancellationToken cancellationToken)
        {
            

                // Base Implementation for all requests
                Result result = default;
                var command = request as BasePrinterCommand;

                if (command!.HasMagn)
                {
                    if (string.IsNullOrEmpty(command.Track1) || string.IsNullOrEmpty(command.Track2) || string.IsNullOrEmpty(command.Track3))
                        throw new Exception("Empty Track Recieved");
                    result = printer.WriteMagn(command.PrinterName, command.Track1, command.Track2, command.Track3);
                    if (!result.IsFailure)
                        throw new PrinterException(result.Error);
                }
                

             
        }
    }
}
