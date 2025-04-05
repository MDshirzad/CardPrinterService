using CSharpFunctionalExtensions;
using Hardware.Laser;
using Hardware.Printer.Contracts;
using Hardware.Roller;
using MessageHandler.Contracts;
using MessageHandler.Handlers;
using MessageHandler.Messages.Api.Response;
using MessageHandler.Messages.DeviceErrors;
using System.Net.Http.Headers;
using Utility.Contracts;

namespace MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.SingleSideLaser.Front.WithRibbon.YMCKO.SingleSide
{
    internal class LaserPrintSingleSideYMCKOCommandHanlder(IPrinter printer, IPathUtility utility,
       ILaserHandler laserHandler,
       IRollerHandler rollerHandler,
       IImageUtility imageUtility
        ) : BasePrintCommandHandler<LaserPrintWithSingleSideYMCKO>(printer)
    {
        public override async Task<Result<MessageResult>> Handle(LaserPrintWithSingleSideYMCKO request, CancellationToken cancellationToken)
        {
            base.WriteMagnIfNeeded(request, cancellationToken);
            var path = imageUtility.StoreLaserImage(request.FrontImage, false);
            if(path.IsFailure)
                return Result.Failure<MessageResult>(GeneralErrorConstatns.ImageStoringError);
            var pathFrontColored = imageUtility.StoreColored(imageUtility.GetVarnishImageBase64(), request.FrontColoredImage);
            if (pathFrontColored.IsFailure)
                return Result.Failure<MessageResult>(GeneralErrorConstatns.ImageStoringError);
            var printColoreResult = printer.Print_SingleSide_YMCKO(request.PrinterName, pathFrontColored.Value.KFilePath,
                pathFrontColored.Value.ColoredFilePath, utility.GetOFileBMPPath());
            if (printColoreResult.IsSuccess) 
            {  
           
                var status = rollerHandler.GetStatus();
                if (status == RollerConstants.CardStatus.CardInMiddle)
                {
                    var laserEngraveResult = laserHandler.Engrave(path.Value, request.X, request.Y);
                    if (laserEngraveResult.IsSuccess)
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
            return Result.Failure<MessageResult>(PrinterErrorConstants.ErrorOnPrint);

        }
    }
}
