using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Azure.Functions.Worker.Configuration;

namespace ApiIsolated
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices(services =>
                {
                    //services.AddCors(options =>
                    //{
                    //    options.AddDefaultPolicy(builder =>
                    //        builder.WithOrigins("https://localhost:44338")
                    //            .AllowAnyMethod()
                    //            .AllowAnyHeader());
                    //});
                })
                .Build();

            host.Run();
        }
    }


}