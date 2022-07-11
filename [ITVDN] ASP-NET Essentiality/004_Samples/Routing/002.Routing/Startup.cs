using System;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;


namespace _002.Routing
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            // определяем обработчик маршрутов
            var myRouteHandlerHome = new RouteHandler(HandleHome);
            var myRouteHandlerHomeCourses = new RouteHandler(HandleHomeCourses);

            // создаем маршруты, используя обработчики
            var routeBuilderHome = new RouteBuilder(app, myRouteHandlerHome);
            var routeBuilderHomeCourses = new RouteBuilder(app, myRouteHandlerHomeCourses);

            // само определение маршрутов - они должны соответствовать заданным статическим шаблонам
            routeBuilderHome.MapRoute("default", "Home");
            routeBuilderHomeCourses.MapRoute("default", "Home/Courses");

            // строим маршруты
            app.UseRouter(routeBuilderHome.Build());
            app.UseRouter(routeBuilderHomeCourses.Build());

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Default page.");
            });
        }

        // собственно обработчики маршрутов
        private async Task HandleHome(HttpContext context)
        {
            await context.Response.WriteAsync("Home page.");
        }

        private async Task HandleHomeCourses(HttpContext context)
        {
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
        }
    }
}
