using CSharpFunctionalExtensions;
using MessageHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler.Handlers.SingleSideKHandle
{
    internal class SingleSideKCommandHandler : ICommandHandler<SingleSideK>
    {
        public Task<Result<MessageResult>> Handle(SingleSideK request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
