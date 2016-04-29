using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using ASP_NET_Core_Fundamentals.Services;
using System;

namespace ASP_NET_Core_Fundamentals
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. 
        // Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IGreeter, Greeter>();
        }

        // This method gets called by the runtime. 
        //Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment environment,
            IGreeter greeter)
        {
            app.UseIISPlatformHandler();

            if (environment.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                //production
            
            app.UseRuntimeInfoPage("/info");

            //app.UseDefaultFiles();
            //app.UseStaticFiles();

            //The above 2 lines can be replaced by
            app.UseFileServer();

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                //throw new Exception("Error!");

                var greeting = greeter.GetGreeting();
                await context.Response.WriteAsync(greeting);
            });
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
