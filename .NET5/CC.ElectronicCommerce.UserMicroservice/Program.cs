using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//dotnet CC.ElectronicCommerce.UserMicroservice.dll --urls="http://*:7001"
namespace CC.ElectronicCommerce.UserMicroservice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                                        .ConfigureAppConfiguration((hostBuilderContext, configurationBuilder) =>
                                        {
                                            configurationBuilder.AddCommandLine(args);
                                        })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}