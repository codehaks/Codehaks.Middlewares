using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Codehaks.Middlewares.SendFile
{
    internal class SendFileMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly SendFileMiddlewareOptions _options;

        public SendFileMiddleware(RequestDelegate next, IOptions<SendFileMiddlewareOptions> options)
        {
            _options = options.Value;
            _next = next;
        }

        public Task Invoke(HttpContext context)
        {
            if (!string.IsNullOrEmpty(_options.FilePath))
            {
                var file = new Microsoft.Extensions.FileProviders.Physical.PhysicalFileInfo(
                    new System.IO.FileInfo(_options.FilePath));
                context.Response.SendFileAsync(file);

                return Task.CompletedTask;
            }
            else
            {
                return Task.CompletedTask;
            }
        }
    }
}