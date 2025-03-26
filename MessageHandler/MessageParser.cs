using MessageHandler.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler
{
    internal class MessageParser(IParser parser) : IMessageParser
    {
        public object ParseMessage(string message)
        {
            BaseResponse response = default!;
            try
            {
                var pars = parser.Parse(message);
                response = new SuccessResponse("Successfull");
                
            }
            catch (Exception ex)
            {

                response = new ErrorResponse(ex.Message);

            }
           return JsonConvert.SerializeObject(response);

        }
        
    }
}
