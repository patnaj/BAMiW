using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LAB1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.AddConsole();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("http://*:5000");
                    //webBuilder.UseUrls("http://127.0.0.1:5000");
                    
                });

    }
}

/*
 browser.cokie=".AspNetCore.Mvc.CookieTempDataProvider=CfDJ8Coj0sk3f3NKmYeIeYMdS79czAIyyoFFLg6y5llUKTSxmXL4KYI8DASnverJzdohP-yKFxTdb_C6k2WGANexgUOQRi4vEvxrqYrArF4VMgv1MEsWm6tO7qgpDuOVjyZzaQxpaSZrAt_XgGyMdG209WjK54uYeQG_Qnb-mGwx1vEqMCO8sLlLP7zbRAxCfSYnFg"
    name: ".AspNetCore.Mvc.CookieTempDataProvider",
    value: "CfDJ8Coj0sk3f3NKmYeIeYMdS79czAIyyoFFLg6y5llUKTSxmXL4KYI8DASnverJzdohP-yKFxTdb_C6k2WGANexgUOQRi4vEvxrqYrArF4VMgv1MEsWm6tO7qgpDuOVjyZzaQxpaSZrAt_XgGyMdG209WjK54uYeQG_Qnb-mGwx1vEqMCO8sLlLP7zbRAxCfSYnFg"
  });
*/