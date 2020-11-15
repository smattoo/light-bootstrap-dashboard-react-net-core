using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace sample_dashboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            var host = CreateWebHostBuilder(args);

            // requires using Microsoft.Extensions.Configuration;
            if (Debugger.IsAttached || args.Contains("--debug"))
            {
                host.Build().Run();
            }
            else
            {
                var pathToExe = Process.GetCurrentProcess().MainModule.FileName;
                var pathToContentRoot = Path.GetDirectoryName(pathToExe);
                host.UseContentRoot(pathToContentRoot).Build().RunAsService();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                // .ConfigureAppConfiguration((builderContext, config) =>
                // {
                // IHostingEnvironment env = builderContext.HostingEnvironment

                // config.SetBasePath(env.ContentRootPath)
                //        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                //       .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
                //  })
                .UseUrls("http://localhost:5002")
                .UseStartup<Startup>();
    }
}
