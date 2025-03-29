using CSharpFunctionalExtensions;
using Hardware.Printer.Contracts;
using Mapster;
using MediatR;
using MessageHandler.Contracts;
using MessageHandler.Handlers.SingleSideKHandle;
using MessageHandler.Messages.ResponseMessages;
using Newtonsoft.Json.Linq;


namespace MessageHandler.Handlers.WithRoller.SingleSideKWithRoller
{
    internal class SingleSideKWithRollerCommandHandler (IPrinter printer,ISender sender): ICommandHandler<SingleSideKWithRollerCommand>
    {
   public  async     Task<Result<MessageResult>>  Handle(SingleSideKWithRollerCommand request, CancellationToken cancellationToken)
        {
            Result result = default;
            //Adapt will copy that object to singleSideK command to let the mediatR call SingleSideKCommandHandler
            var withourRollerBaseHandler = request.Adapt<SingleSideKCommand>();
              result = await sender.Send(withourRollerBaseHandler);
            //Magn and Print Done Just Need to eject by roller
            if(result.IsFailure)
            {
                return Result.Failure<MessageResult>(result.Error);
            }
            return new MessageResult(FunctionResponse.SuccessResponse);
        }
    }
}
