using CSharpFunctionalExtensions;
using Hardware.Printer.Contracts;
using MessageHandler.Contracts;
using MessageHandler.Messages.ResponseMessages;

namespace MessageHandler.Handlers.SingleSideKHandle
{
    internal class SingleSideKCommandHandler(IPrinter printer) : BasePrintCommandHandler<SingleSideKCommand>(printer)
    {
        public async Task<Result<MessageResult>> Handle(SingleSideKCommand request, CancellationToken cancellationToken)
        {
            Result result = default;
            result =await Handle(request,cancellationToken);  
            if (result.IsSuccess)
                return new MessageResult(FunctionResponse.SUCCESSFULL_PRINT_OPERATION);
            return Result.Failure<MessageResult>(result.Error);
        }
    }
}
