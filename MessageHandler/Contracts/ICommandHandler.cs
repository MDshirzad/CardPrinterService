using CSharpFunctionalExtensions;
using MediatR;

namespace MessageHandler.Contracts
{
    internal interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result<MessageResult>>
     where TCommand : ICommand
    { }

}
