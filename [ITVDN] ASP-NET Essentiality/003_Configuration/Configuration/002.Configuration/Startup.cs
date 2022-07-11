using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace _002.Configuration
{
    public class Startup
    {
        // Свойство, хранящее набор значений конфигурации приложения
        public IConfiguration AppConfiguration { get; set; }

        public Startup()
        {
            // Создаем экземпляр класса строителя конфигурации
            var builder = new ConfigurationBuilder();

            // Добавляем в коллекцию новый набор значений
            builder.AddInMemoryCollection(new Dictionary<string, string>
                {
                    {"ApplicationName", null},
                    {"EnvironmentName", null}
                });

            // создаем конфигурацию
            AppConfiguration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Присваиваем ключам конфигурации значения из среды, в которой было запущено приложение
            AppConfiguration["ApplicationName"] = env.ApplicationName;
            AppConfiguration["EnvironmentName"] = env.ContentRootPath;

            string AppName = $"<br>Application name: {AppConfiguration["ApplicationName"]}</br>";
            string EnvName = $"<br>Environment name: {AppConfiguration["EnvironmentName"]}</br>";

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(AppName + EnvName);
            });
        }
    }
}
