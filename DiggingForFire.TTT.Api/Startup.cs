using DiggingForFire.TTT.Application.Interfaces;
using DiggingForFire.TTT.Application.Services;
using DiggingForFire.TTT.DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace DiggingForFire.TTT.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string server = "";
            string database = "";
            string userId = "";
            string password = "";

            string connectionString = $"Server={server};Database={database};User Id={userId};Password='{password}';";

            services
                .AddDbContext<TodoContext>(options => options.UseSqlServer(connectionString))
                .AddControllers()
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());

            services.AddTransient<ITodoService, TodoService>();
            services.AddTransient<ITodoContext, TodoContext>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
