using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog.Formatting.Compact;
using Serilog;
using System;
using System.Threading.Tasks;
using UsersQueueApi.Application.Common.Utils;
using Serilog.Events;

namespace UsersQueueApi.WebUI
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
           
            var host = CreateHostBuilder(args).Build();
            Log.Logger = new LoggerConfiguration().MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
               .WriteTo.File(VariablesUtil.GetDirectoryAppSettings()+"Log/log.txt")
               .CreateLogger();
            await host.RunAsync();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                 .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    var env = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");
                    webBuilder.UseStartup<Startup>();
                   
                    webBuilder.ConfigureAppConfiguration(config =>
                        config.SetBasePath(VariablesUtil.GetDirectoryAppSettings())
                        .AddJsonFile($"appsettings.{env}.json"));
                });
    }
}
