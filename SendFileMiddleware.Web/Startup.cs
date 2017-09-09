using Codehaks.Middlewares.SendFile;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace SendFileMiddleware.Web
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSendFile(@"filePath");   // "C:\myfile.jpg

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello world");
            });
        }
    }
}