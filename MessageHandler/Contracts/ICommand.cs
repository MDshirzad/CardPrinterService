using CSharpFunctionalExtensions;
using MediatR;

namespace MessageHandler.Contracts
{

    internal interface ICommand : IRequest<Result<MessageResult>>
    {
    }
}
