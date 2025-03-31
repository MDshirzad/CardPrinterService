using CSharpFunctionalExtensions;
using MediatR;
using MessageHandler.Contracts;

namespace MessageHandler.Handlers.Laser.WithRoller.SingleSideLaser.Front.WithoutRibbon.SingleSide
{
    internal class LaserPrintWithRollerCommandHandler : ICommandHandler<LaserPrintWithRollerCommand>
    {
        Task<Result<MessageResult>> IRequestHandler<LaserPrintWithRollerCommand, Result<MessageResult>>.Handle(LaserPrintWithRollerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
