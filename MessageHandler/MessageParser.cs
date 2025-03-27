using CSharpFunctionalExtensions;
using MediatR;
using MessageHandler.Contracts;
using MessageHandler.Response;
using Newtonsoft.Json;

namespace MessageHandler
{
    internal class MessageParser(IParser parser, ISender mediator) : IMessageParser
    {
        public async Task<object> ParseMessage(string message)
        {
            BaseResponse response = default!;
            try
            {
                var pars = (parser.Parse(message));
                var handledResult = await mediator.Send(pars);
                var castedFunctionalResult = (Result<MessageResult>)handledResult!;
                if (castedFunctionalResult.IsFailure)
                {
                    response = new ErrorResponse(castedFunctionalResult.Error);
                }
                else
                    response = new SuccessResponse(castedFunctionalResult.Value.InformativeMessage, castedFunctionalResult.Value.data);

            }
            catch (Exception ex)
            {

                response = new ErrorResponse(ex.Message);

            }
            return JsonConvert.SerializeObject(response);

        }

    }
}
