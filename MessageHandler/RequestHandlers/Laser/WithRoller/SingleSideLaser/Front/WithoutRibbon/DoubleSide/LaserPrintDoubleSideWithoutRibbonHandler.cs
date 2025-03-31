using CSharpFunctionalExtensions;
using MessageHandler.Contracts;


namespace MessageHandler.Handlers.Laser.WithRoller.SingleSideLaser.Front.WithoutRibbon.DoubleSide
{
    internal class LaserPrintDoubleSideWithoutRibbonHandler : ICommandHandler<LaserPrintDoubleSideWithoutRibbon>
    {
        public Task<Result<MessageResult>> Handle(LaserPrintDoubleSideWithoutRibbon request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
