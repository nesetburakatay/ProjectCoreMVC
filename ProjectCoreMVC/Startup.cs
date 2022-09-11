using BusinessLayer.ValidationRules;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCoreMVC
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
            //.AddFluentValida.... dan sonras� Fluent validasyon i�lemlerini projeye servis olarak ekler.
            services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<WriterValidator>());


            //services.AddSession();// session servisini ekler...........................


            //a�a��daki komut e�er gitti�in sayfada yetkili de�ilsen seni belirledi�in controllerdaki action metoduna y�nlendirir.
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>{options.LoginPath = "/Login/Index/";});



            //authorization b�t�n projeye a��a��daki kod ile entegre edilir.
            //services.AddMvc(config =>
            //{
            //    // using Microsoft.AspNetCore.Mvc.Authorization;
            //    // using Microsoft.AspNetCore.Authorization;
            //    var policy = new AuthorizationPolicyBuilder()
            //                     .RequireAuthenticatedUser()
            //                     .Build();
            //    config.Filters.Add(new AuthorizeFilter(policy));
            //});......................................................................................................................
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
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error", "?Code={0}"); //bu middlewarein g�revi 404 hatas� al�nd���nda kontroller� "ErrorPage" kontrolleri alt�ndaki "Error" aksiyonuna y�nlendirmekdir.
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseSession();//session midwaresini kullan�r.......................


            app.UseRouting();

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
