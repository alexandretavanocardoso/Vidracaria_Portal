using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Vidracaria_Portal.Data.Context;
using Vidracaria_Portal.Models;

namespace Vidracaria_Portal
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
            services.AddDbContext<VidracariaContext>(options =>
                   options.UseMySQL(Configuration.GetConnectionString("VidracariaContext")));

            // Serviço de Identity
            services.AddIdentity<UsuarioModel, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 6; // numero minimo
                options.Password.RequireDigit = false; //
                options.Password.RequireUppercase = false; // letra maiusculo
                options.Password.RequiredUniqueChars = 0; //Caracter espacial
                options.Password.RequireLowercase = false; // letra minuscula
                options.Password.RequireNonAlphanumeric = false; // numero açfanumerico
                options.User.RequireUniqueEmail = true; //requer email unico
                options.Lockout.AllowedForNewUsers = true; // bloqueio de usuario
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(2); //Tempo bloqueado
                options.Lockout.MaxFailedAccessAttempts = 5;//numero maximo de tentativas
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<VidracariaContext>()
            .AddDefaultTokenProviders()
            .AddClaimsPrincipalFactory<CustomClaimsFactory>();


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

            app.UseAuthentication(); // Necessario para saber quem esta logando

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Home}/{id?}");
            });
        }
    }
}
