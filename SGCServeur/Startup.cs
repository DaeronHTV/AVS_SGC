using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using SGCServeur.Config;
using SGCServeur.Models.Bdd;

namespace SGCServeur
{
    public class Startup
    {
        private readonly string ConnectionString;
        private readonly ApiInformation ApiInformation;
        //private readonly Provider ProviderApi;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            ApiInformation = Configuration.GetSection(nameof(ApiInformation)).Get<ApiInformation>();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SGCContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllers();
            services.AddOpenApiDocument(document =>
            {
                document.PostProcess = d =>
                {
                    d.Info.Title = ApiInformation.Title;
                    d.Info.Description = ApiInformation.Description;
                    d.Info.Version = ApiInformation.Version;
                    d.Info.License = ApiInformation.License;
                    d.Info.Contact = ApiInformation.Contact;
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /*else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }*/
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
