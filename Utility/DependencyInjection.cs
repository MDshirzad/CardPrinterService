using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
