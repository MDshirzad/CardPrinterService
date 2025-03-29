using MessageHandler.Contracts;
using MessageHandler.Exceptions;
using MessageHandler.Handlers.SingleSideKHandle;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MessageHandler
{
    internal class CodeBaseMessageParser : IParser
    {
        public object Parse(string input)
        {

            var code = input.Substring(0, 3);
            input = input.Remove(0, 3);
            var classType = GetTypeByCommand(code);
            if (classType == null)
                throw new JsonParserException("Invalid Code");
            try
            {
                var jsonObject = JsonConvert.DeserializeObject<JObject>(input);

                if (jsonObject == null)
                    throw new ArgumentNullException();

                var resultMap = jsonObject.ToObject(classType);
                return resultMap;
            }
            catch (ArgumentNullException)

            {
                throw new JsonParserException();
            }
            catch
            {

                throw new UnHandledException();
            }
        }


        Type? GetTypeByCommand(string code)
        {
            return code switch
            {
                "960" => typeof(SingleSideK),

                _ => throw new Exception("Invalid Command")
            };

            //var type = Assembly.GetExecutingAssembly()
            //    .GetTypes()
            //    .FirstOrDefault(t => t.Name.Equals(className, StringComparison.OrdinalIgnoreCase) && typeof(IRequest).IsAssignableFrom(t));
            //return type;

        }
    }
}
