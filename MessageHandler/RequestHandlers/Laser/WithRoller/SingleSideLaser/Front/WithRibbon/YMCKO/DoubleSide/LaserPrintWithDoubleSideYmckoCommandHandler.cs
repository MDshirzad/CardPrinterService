using CSharpFunctionalExtensions;
using MessageHandler.Contracts;

namespace MessageHandler.Handlers.Laser.WithRoller.SingleSideLaser.Front.WithRibbon.YMCKO.DoubleSide
{
    internal class LaserPrintWithDoubleSideYmckoCommandHandler : ICommandHandler<LaserPrintWithDoubleSideYmckoCommand>
    {
        public Task<Result<MessageResult>> Handle(LaserPrintWithDoubleSideYmckoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
