using TheWall.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.IO;

namespace TheWall
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // var connection = @"Server=localhost;
            //                 Port=8889;
            //                 database=efwall;
            //                 uid=root;
            //                 pwd=root;";
            // services.AddDbContext<DataContext>(options => options.UseMySql(connection));
            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseSession();
            app.UseStaticFiles();

            app.UseMvc();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}