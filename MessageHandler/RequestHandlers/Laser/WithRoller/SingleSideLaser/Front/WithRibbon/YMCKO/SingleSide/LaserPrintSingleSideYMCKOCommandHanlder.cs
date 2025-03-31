using CSharpFunctionalExtensions;
using MessageHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Handlers.Laser.WithRoller.SingleSideLaser.Front.WithRibbon.YMCKO.SingleSide
{
    internal class LaserPrintSingleSideYMCKOCommandHanlder : ICommandHandler<LaserPrintWithSingleSideYMCKO>
    {
        public Task<Result<MessageResult>> Handle(LaserPrintWithSingleSideYMCKO request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
