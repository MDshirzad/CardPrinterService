using MediatR;
using MessageHandler.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Contracts;

namespace MessageHandler.PipeLine
{
    internal class FlusherPipeline<TRequest, TResponse>(IPathUtility pathUtility) : IPipelineBehavior<TRequest, TResponse>
    {
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            var result = await next();

            if (request.GetType().BaseType == typeof(BasePrinterCommand))
            {

                var basePath = pathUtility.BaseImagePath();
                var files = Directory.GetFiles(basePath);
                foreach (var item in files)
                {
                    if (item.EndsWith("o.bmp"))
                        continue;
                    try
                    {
                        File.Delete(item);
                    }
                    catch (Exception)
                    {

                        
                    }
                 

                }
                

            }
            return result;
        }
    }
}
