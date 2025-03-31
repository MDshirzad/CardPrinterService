using CSharpFunctionalExtensions;
using MessageHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
