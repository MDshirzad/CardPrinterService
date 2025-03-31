using CSharpFunctionalExtensions;
using MessageHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Handlers.Laser.WithRoller.SingleSideLaser.Back.WithoutRibbon
{
    internal class BackSideLaserCommandHandler : ICommandHandler<BackSideLaserCommand>
    {
        public Task<Result<MessageResult>> Handle(BackSideLaserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
