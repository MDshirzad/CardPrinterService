using Microsoft.Extensions.DependencyInjection;

namespace NetworkAdapter
{
    public static class DependencyInjection
    {
        public static void AddNetworkAdapterServices(this IServiceCollection services)
        {
            services.AddSingleton<INotifierService, NotifierServer>();
        }
    }
}
