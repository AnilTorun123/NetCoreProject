using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using NCP.Business.Concrete.EntityService;
using NCP.Business.Interfaces;
using NCP.DataAccessLayer.EntityProvider.Repository.Concrete;
using NCP.DataAccessLayer.EntityProvider.Repository.Interfaces;
using NCP.WebUI.Middlewares;
using NCP.WebUI.Services;

namespace NCP.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICategoryService, Business.Concrete.SqlService.CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddSingleton<IWebUserService, WebUserService>();
            services.AddSingleton<ICartSessionService, CartSessionService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddMvc();
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddDistributedMemoryCache();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseMvc(ConfigureRoutes);
            app.UseFileServer();
            app.UseNodeModules(env.ContentRootPath);
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {
            routeBuilder.MapRoute(
                "Default",
                "{controller=Home}/{action=Index}/{id?}"
                );
        }
    }
}
