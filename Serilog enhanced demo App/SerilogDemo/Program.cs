using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using Serilog.Events;

namespace SerilogDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {   //BUILD CONFIGURATION SYSTEM
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .MinimumLevel.Debug()
                .WriteTo.File(path: @"C:\Users\Chaitanya_Pallamala\Desktop\MENTOR TASK\SerilogDemoApp\debug.log", rollingInterval: RollingInterval.Day)
                .WriteTo.File(path: @"C:\Users\Chaitanya_Pallamala\Desktop\MENTOR TASK\SerilogDemoApp\info.log", restrictedToMinimumLevel: LogEventLevel.Information, rollingInterval: RollingInterval.Day)
                .WriteTo.File(path: @"C:\Users\Chaitanya_Pallamala\Desktop\MENTOR TASK\SerilogDemoApp\error.log", restrictedToMinimumLevel: LogEventLevel.Error, rollingInterval: RollingInterval.Day)
                .CreateLogger();
                
            
                

            try
            {
                Log.Information("our application is starting up");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception e)
            {
                Log.Fatal(e, "Application failed to even start");
            }
            finally
            {
               //any log messages still pending(not written yet) will be closed 
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()//using serilog logger instead of default Ilogger
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
