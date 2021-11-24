using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur
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
            //services.AddControllersWithViews();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllers();
            services.AddOpenApiDocument(document =>
            {
                document.PostProcess = d =>
                {
                    d.Info.Title = "SGCServeur";
                    d.Info.Description = "Serveur de gestion des compétences du logiciel SCG";
                    d.Info.Version = "Alpha";
                    d.Info.License = new NSwag.OpenApiLicense
                    {
                        Name = "License Dedalus",
                        Url = "https://www.dedalus.com/fr/fr/"
                    };
                    d.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Aurélien Avanzino",
                        Email = "aurelien.avanzino@dedalus.eu"
                    };
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
