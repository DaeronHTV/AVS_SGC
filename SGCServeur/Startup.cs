using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SGCServeur.Config;
using SGCServeur.Models.Bdd;
using Core.Api.Config;

namespace SGCServeur
{
    public class Startup
    {
        private readonly string ConnectionString;
        //private readonly Provider ProviderApi;

        public Startup(IConfiguration configuration)
        {
            ConfigHelper.Initialisation(configuration);
            Configuration = configuration;
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SGCContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllers();
            services.AddOpenApiDocument(document =>
            {
                document.PostProcess = d => { d.Info = ConfigHelper.ApiInformation; };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
