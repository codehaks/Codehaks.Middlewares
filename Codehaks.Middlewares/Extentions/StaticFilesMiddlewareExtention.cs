using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Builder
{
    public static class UseStaticFilesMiddlewareExtention
    {
        public static IApplicationBuilder UseStaticFilesFromPath(
            this IApplicationBuilder builder, string folderPath)
        {
            var options = new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(folderPath)
            };

            return builder.UseMiddleware<StaticFileMiddleware>(Options.Create(options));
        }
    }
}