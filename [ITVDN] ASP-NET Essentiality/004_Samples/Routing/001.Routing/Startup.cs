using System;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;

namespace _001.Routing
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // добавляем сервис маршрутизации
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            var routeBuilder = new RouteBuilder(app);

            routeBuilder.MapRoute("Home",
                async context => {
                    await context.Response.WriteAsync("Home page.");
                });

            routeBuilder.MapRoute("Home/Courses",
                async context => {
                    StringCollection courses = new StringCollection()
                    {
                        "C# Starter",
                        "C# Essential",
                        "C# Professional",
                        "C# Patterns of Design"
                    };

                    await context.Response.WriteAsync("Here is the list of avaliable courses:");

                    foreach (var course in courses)
                        await context.Response.WriteAsync($"<br>{course}</br>");
                });

            app.UseRouter(routeBuilder.Build());

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Default page.");
            });
        }
    }
}
