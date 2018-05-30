using Codehaks.Middlewares.SendFile;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Builder
{
    public static class SendFileMiddlewareExtension
    {
        public static IApplicationBuilder UseSendFile(
            this IApplicationBuilder builder, SendFileMiddlewareOptions options)
        {
            return
            builder.UseMiddleware<SendFileMiddleware>(Options.Create(options));
        }

        public static IApplicationBuilder UseSendFile(
            this IApplicationBuilder builder, string filePath)
        {
            var options = new SendFileMiddlewareOptions()
            {
                FilePath = filePath
            };

            return
            builder.UseMiddleware<SendFileMiddleware>(Options.Create(options));
        }
    }
}