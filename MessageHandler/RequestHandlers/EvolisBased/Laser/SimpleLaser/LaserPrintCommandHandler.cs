using CSharpFunctionalExtensions;
using MessageHandler.Contracts;

namespace MessageHandler.RequestHandlers.EvolisBased.Laser.SimpleLaser
{
    internal class LaserPrintCommandHandler : ICommandHandler<LaserPrintCommand>
    {
        public Task<Result<MessageResult>> Handle(LaserPrintCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
