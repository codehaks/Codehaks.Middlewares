using Codehaks.Middlewares.SendFile;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

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

            app.UseSendFile(@"file");   // "C:\myfile.jpg
        }
    }
}