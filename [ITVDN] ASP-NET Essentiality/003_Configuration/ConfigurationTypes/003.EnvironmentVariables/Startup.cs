using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

namespace _003.EnvironmentVariables
{
    public class Startup
    {
        // Свойство, хранящее набор значений конфигурации приложения
        public IConfiguration AppConfiguration { get; set; }

        public Startup()
        {
            // Создаем экземпляр класса строителя конфигурации
            var builder = new ConfigurationBuilder();

            // Подключаем переменные окружения, в рамках которого было запущено наше приложение
            builder.AddEnvironmentVariables();

            // Создаем конфигурацию
            AppConfiguration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            string arch = $"<br>Architecture: {AppConfiguration["PROCESSOR_ARCHITECTURE"]}</br>";
            string model = $"<br>Model: {AppConfiguration["PROCESSOR_LEVEL"]}</br>";

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(arch + model);
            });
        }
    }
}
