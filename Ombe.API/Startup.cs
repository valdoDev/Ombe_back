using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ombe.API.Configuration;
using Ombe.Data.Context;
using System;

namespace Ombe.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OmbeDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddControllers();

            services.WebApiConfig();

            services.AddSwaggerConfig();

           
            var bdTimeout = new TimeSpan(0, 0, 10);
            services.AddHealthChecks()
                    .AddCheck("Tabelas acesso", new SqlServerHealthCheck(Configuration.GetConnectionString("DefaultConnection")), timeout: bdTimeout)
                    .AddSqlServer(Configuration.GetConnectionString("DefaultConnection"), name: "SQL Server", timeout: bdTimeout);

            services.AddHealthChecksUI(opt =>
                    {
                        opt.SetEvaluationTimeInSeconds(300); //time in seconds between check    
                        opt.MaximumHistoryEntriesPerEndpoint(60); //maximum history of checks    
                    })
                    .AddInMemoryStorage();

            services.ResolveDependencies();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwaggerConfig(provider);

            app.UseHealthChecks("/hc-data-ui", new HealthCheckOptions()
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
            });

            app.UseHealthChecksUI(options =>
            {
                options.UIPath = "/hc-monitor";
            });


        }
    }
}
