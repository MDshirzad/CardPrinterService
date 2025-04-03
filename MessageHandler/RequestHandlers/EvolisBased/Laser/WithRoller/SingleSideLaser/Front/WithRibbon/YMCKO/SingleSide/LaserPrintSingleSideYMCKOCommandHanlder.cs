using CSharpFunctionalExtensions;
using MessageHandler.Contracts;

namespace MessageHandler.RequestHandlers.EvolisBased.Laser.WithRoller.SingleSideLaser.Front.WithRibbon.YMCKO.SingleSide
{
    internal class LaserPrintSingleSideYMCKOCommandHanlder : ICommandHandler<LaserPrintWithSingleSideYMCKO>
    {
        public Task<Result<MessageResult>> Handle(LaserPrintWithSingleSideYMCKO request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
