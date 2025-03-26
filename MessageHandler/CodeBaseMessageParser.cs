using MessageHandler.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler
{
    internal class CodeBaseMessageParser : IParser
    {
        public object Parse(string input)
        {
            
            var code = input.Substring(0, 3);
            input = input.Remove(0, 3);
            try
            { 
            var result =  JsonConvert.DeserializeObject(input);
            if (result == null)
                    throw new ArgumentNullException();
                return result;
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
    }
}
