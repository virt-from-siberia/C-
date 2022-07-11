using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Ini;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration.Xml;

namespace _006.Multiple
{
    public class Startup
    {
        // Свойство, хранящее набор значений конфигурации приложения
        public IConfiguration AppConfig { get; set; }

        public Startup(IHostingEnvironment env)
        {
            // Создаем экземпляр класса строителя конфигурации
            var builder = new ConfigurationBuilder();

            // Устанавливаем путь, по которому будет производится поиск файла конфигурации
            builder.SetBasePath(env.ContentRootPath);

            // Задаем имена используемых файлов конфигурации
            builder.AddIniFile("IniConfig.ini");
            builder.AddJsonFile("JsonConfig.json");
            builder.AddXmlFile("XmlConfig.xml");

            // Добавляем в коллекцию новый набор значений
            builder.AddInMemoryCollection(new Dictionary<string, string>()
                {
                    {"ColorMemory", "gray"},
                    {"ContentMemory", "Memory configuration is currently shown."}
                });

            // Создаем конфигурацию
            AppConfig = builder.Build();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"<p style='color:{AppConfig["ColorMemory"]};'>{AppConfig["ContentMemory"]}</p>");
                await context.Response.WriteAsync($"<p style='color:{AppConfig["ColorIni"]};'>{AppConfig["ContentIni"]}</p>");
                await context.Response.WriteAsync($"<p style='color:{AppConfig["ColorXml"]};'>{AppConfig["ContentXml"]}</p>");
                await context.Response.WriteAsync($"<p style='color:{AppConfig["ColorJson"]};'>{AppConfig["ContentJson"]}</p>");
            });
        }
    }
}
