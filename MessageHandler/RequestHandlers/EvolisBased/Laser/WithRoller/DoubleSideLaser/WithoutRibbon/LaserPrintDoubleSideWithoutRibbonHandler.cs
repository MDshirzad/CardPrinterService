using CSharpFunctionalExtensions;
using MessageHandler.Contracts;


namespace MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.DoubleSideLaser.WithoutRibbon
{
    internal class LaserPrintDoubleSideWithoutRibbonHandler : ICommandHandler<LaserPrintDoubleSideWithoutRibbon>
    {
        public Task<Result<MessageResult>> Handle(LaserPrintDoubleSideWithoutRibbon request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
