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
using TimKiemHangTon.Models;

namespace TimKiemHangTon
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


            services.AddDbContext<db_KhoHangContext>(options => options.UseSqlServer(Configuration.GetConnectionString("db_KhoHang")));

        }


        //Microsoft.EntityFrameworkCore
        //Microsoft.EntityFrameworkCore.SqlServer
        //Microsoft.EntityFrameworkCore.Tools
        //Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
        //AspNetCoreHero.ToastNotification


        //Chuoi ket noi
        //Scaffold-DbContext "Server=TRANVUHAO;Database=db_Vaccine;Integrated Security=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models 
        //Scaffold-DbContext "Server=TRANVUHAO;Database=db_Vaccine;Integrated Security=true;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force



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
