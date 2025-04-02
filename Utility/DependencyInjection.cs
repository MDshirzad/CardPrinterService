using Microsoft.Extensions.DependencyInjection;
using Utility.Contracts;

namespace Utility
{
    public static class DependencyInjection
    {
        public static void AddImageSertvices(this IServiceCollection services)
        {
            services.AddSingleton<IImageUtility, ImageToolsImproved>();
            services.AddSingleton<IPathUtility, PathUtility>();
        }
    }
}
