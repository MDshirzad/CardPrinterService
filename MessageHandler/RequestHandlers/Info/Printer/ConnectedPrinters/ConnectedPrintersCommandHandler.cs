using CSharpFunctionalExtensions;
using MediatR;
using MessageHandler.Contracts;
using MessageHandler.Messages.Api.Response;
using System.Management;
 

namespace MessageHandler.RequestHandlers.Info.Printer.ConnectedPrinters
{
    internal class ConnectedPrintersCommandHandler : ICommandHandler<ConnectedPrintersCommand>
    {
        public async Task<Result<MessageResult>> Handle(ConnectedPrintersCommand request, CancellationToken cancellationToken)
        {
            List<string> list = new List<string>();

            var printerQuery = new ManagementObjectSearcher("SELECT * from Win32_Printer");

            foreach (var printer in printerQuery.Get())
            {
                list.Add(printer.GetPropertyValue("Name").ToString());


            }

            return new MessageResult( 
                FunctionResponse.SUCCESS_RESPONSE,
                 string.Join(", ", list));
           

        }
 
    }
}
