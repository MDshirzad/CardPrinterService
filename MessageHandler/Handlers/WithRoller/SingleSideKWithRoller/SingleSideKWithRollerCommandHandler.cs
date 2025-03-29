using CSharpFunctionalExtensions;
using Hardware.Printer.Contracts;
using Mapster;
using MediatR;
using MessageHandler.Contracts;
using MessageHandler.Handlers.SingleSideKHandle;
using Newtonsoft.Json.Linq;


namespace MessageHandler.Handlers.WithRoller.SingleSideKWithRoller
{
    internal class SingleSideKWithRollerCommandHandler (IUsbPrinter printer,ISender sender): ICommandHandler<SingleSideKWithRollerCommand>
    {
   public  async     Task<Result<MessageResult>>  Handle(SingleSideKWithRollerCommand request, CancellationToken cancellationToken)
        {
            Result result = default;
            var withourRollerBaseHandler = request.Adapt<SingleSideKCommand>();
              result = await sender.Send(withourRollerBaseHandler);
            if(result.IsFailure)
            {
                return Result.Failure<MessageResult>(result.Error);
            }
            return new MessageResult("");
        }
    }
}
