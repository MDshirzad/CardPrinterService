using CSharpFunctionalExtensions;
using Hardware.Laser;
using Hardware.Printer.Contracts;
using Hardware.Roller;
using MediatR;
using MessageHandler.Contracts;
using MessageHandler.Handlers;
using MessageHandler.Messages.Api.Response;
using MessageHandler.Messages.DeviceErrors;
using System.Net.NetworkInformation;
using Utility.Contracts;

namespace MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.SingleSideLaser.Front.WithoutRibbon
{
    internal class LaserPrintWithRollerCommandHandler (IPrinter printer,
       ILaserHandler laserHandler,
       IRollerHandler rollerHandler,
       IImageUtility imageUtility

        ): BasePrintCommandHandler<LaserPrintWithRollerCommand>(printer)
    {
        public  override async   Task<Result<MessageResult>>  Handle(LaserPrintWithRollerCommand request, CancellationToken cancellationToken)
        {
            
             base.WriteMagnIfNeeded(request, cancellationToken);
            var path = imageUtility.StoreLaserImage(request.FrontImage,false);
            
          var   ejectResult = printer.EjectCard(request.PrinterName);
            if (ejectResult.IsSuccess)
            { var status = rollerHandler.GetStatus();
                if (status == RollerConstants.CardStatus.CardInMiddle)
                {
                     var laserEngraveResult = laserHandler.Engrave(path.Value, request.X, request.Y);
                    if(laserEngraveResult.IsSuccess)
                    {
                        var ejectRollerResult = rollerHandler.Eject();
                        if (ejectRollerResult.IsSuccess)
                            return new MessageResult(FunctionResponse.SUCCESS_RESPONSE);
                        return Result.Failure<MessageResult>(RollerErrorsConstants.EjectCardError);
                    }
                    return Result.Failure<MessageResult>(LaserErrorConstants.LaserEngraveError);
                }
                return Result.Failure<MessageResult>(RollerErrorsConstants.CardNotOnMidDevice);
            }
            return Result.Failure<MessageResult>(PrinterErrorConstants.ErrorOnEjectCard);
           
        }


    }
}
