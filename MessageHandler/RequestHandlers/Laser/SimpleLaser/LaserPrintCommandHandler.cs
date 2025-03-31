using CSharpFunctionalExtensions;
using MessageHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Handlers.Laser.SimpleLaser
{
    internal class LaserPrintCommandHandler : ICommandHandler<LaserPrintCommand>
    {
        public Task<Result<MessageResult>> Handle(LaserPrintCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
