using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportesYComercializaciónTRANSMI.DB;
using TransportesYComercializaciónTRANSMI.Repositories;

namespace TransportesYComercializaciónTRANSMI
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
            services.AddControllersWithViews();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => {
                    options.LoginPath = "/auth/login";
                    //Se puede configurar mas options
                });

            //Agregar coneccion a BD
            services.AddDbContext<DbEntities>(
                options => options.UseSqlServer(Configuration.GetConnectionString("PfCalidad"))
            );
            //---------------------------------------
            //DEFINICION DE INTERFAS Y CLASE A USAR
            //---------------------------------------
            services.AddTransient<IClienteRepositorio, ClienteRepositorio>();
            services.AddTransient<IEmpleadoRepositorio, EmpleadoRepositorio>();
            services.AddTransient<IPaqueteRepositorio, PaqueteRepositorio>();
            services.AddTransient<IPaqueteClienteRepositorio, PaqueteClienteRepositorio>();
            services.AddTransient<IPaqueteEmpleadoRepositorio, PaqueteEmpleadoRepositorio>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
