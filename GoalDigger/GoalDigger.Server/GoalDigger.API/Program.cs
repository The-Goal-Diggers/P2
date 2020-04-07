using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using GoalDigger.DataStore.Databases;
using Microsoft.Extensions.DependencyInjection;

namespace GoalDigger.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoadDatabase(CreateHostBuilder(args).Build()).Run(); // LOAD THA DATABASE <--
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

    public static IHost LoadDatabase(IHost host)
        {
            using( var dbContext = host.Services.GetRequiredService<GoalDiggerDBContext>())
            {
                // dbContext.Database.EnsureCreated();
                dbContext.Database.Migrate();
            }
            return host;
            
        }
        
    }
}
