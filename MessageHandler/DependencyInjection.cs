using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageHandler
{
    public static class DependencyInjection
    {
        public static void AddMessageHandlerServices(this IServiceCollection services)
        {
            services.AddSingleton<IMessageParser, MessageParser>();
            services.AddSingleton<IParser, CodeBaseMessageParser>();

        }
    }
}
