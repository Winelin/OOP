using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DOGobj.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using DOGobj.ApplicationServices.GetPlatformLightingListUseCase;
using DOGobj.ApplicationServices.Ports.Gateways.Database;
using DOGobj.ApplicationServices.Repositories;
using DOGobj.DomainObjects.Ports;

namespace DOGobj.WebService
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
            services.AddDbContext<DOGobjContext>(opts => 
                opts.UseSqlite($"Filename={System.IO.Path.Combine(System.Environment.CurrentDirectory, "DOGobj.db")}")
            );

            services.AddScoped<IDOGobjDatabaseGateway, DOGobjEFSqliteGateway>();

            services.AddScoped<DbDOGobjRepository>();
            services.AddScoped<IReadOnlyDOGobjRepository>(x => x.GetRequiredService<DbDOGobjRepository>());
            services.AddScoped<IDOGobjRepository>(x => x.GetRequiredService<DbDOGobjRepository>());


            services.AddScoped<IGetDOGobjListUseCase, GetDOGobjListUseCase>();

            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}