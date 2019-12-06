using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NCP.WebUI.Middlewares
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNodeModules(this IApplicationBuilder app, string root)
        {
            var path = Path.Combine(root, "node_modules");
            var options = new StaticFileOptions();
            options.RequestPath = "/node_modules";
            options.FileProvider = new PhysicalFileProvider(path);
            app.UseStaticFiles(options);
            return app;
        }
    }
}
