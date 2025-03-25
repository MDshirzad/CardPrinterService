using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
