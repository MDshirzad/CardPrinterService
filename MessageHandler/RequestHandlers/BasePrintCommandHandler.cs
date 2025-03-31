using CSharpFunctionalExtensions;
using Hardware.Printer.Contracts;
using MessageHandler.Contracts;
using MessageHandler.Messages.Api.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Handlers
{
    internal abstract class BasePrintCommandHandler<T> : ICommandHandler<T> where T : BasePrinterCommand
    {
        IPrinter printer;
        protected BasePrintCommandHandler(IPrinter printer)
        {
            this.printer = printer;    
        }

        public virtual async Task<Result<MessageResult>> Handle(T request, CancellationToken cancellationToken)
        {
            // Base Implementation for all requests
            Result result = default;
            var command = request as BasePrinterCommand;
            
            if (command!.HasMagn )
            {
                if (string.IsNullOrEmpty(command.Track1) || string.IsNullOrEmpty(command.Track2) || string.IsNullOrEmpty(command.Track3))
                    return Result.Failure<MessageResult>(FunctionResponse.InvalidTracks);
                    result = printer.WriteMagn(command.PrinterName, command.Track1, command.Track2, command.Track3);
                if (result.IsFailure)
                    return Result.Failure<MessageResult>(result.Error);
            }
            return   new MessageResult(FunctionResponse.SUCCESSFULL_PRINT_OPERATION) ;

        }
    }
}
