
using MessageHandler.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace MessageHandler
{
    public static class DependencyInjection
    {
        public static void AddMessageHandlerServices(this IServiceCollection services)
        {
            services.AddSingleton<IMessageParser, MessageParser>();
            services.AddSingleton<IParser, CodeBaseMessageParser>();
            var assembly = typeof(DependencyInjection).Assembly;
            services.AddMediatR(c =>
            {
                c.RegisterServicesFromAssembly(assembly);

            });



        }
    }
}
