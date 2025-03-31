using CSharpFunctionalExtensions;
using MessageHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Handlers.Laser.WithRoller.DoubleSideLaser.WithRibbon.YMCKO.DoubleSide
{
    internal class DoubleLaserDoubleSideYmckoCommandHandler : ICommandHandler<DoubleLaserDoubleSideYmckoCommand>
    {
        public Task<Result<MessageResult>> Handle(DoubleLaserDoubleSideYmckoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
