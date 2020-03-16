using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_commere.Datacontext;
using E_commere.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using E_commere.Service.Infaststuctor;
using E_commere.Service.Repository;
using Microsoft.Extensions.FileProviders;
using System.IO;
using System.Collections;

namespace E_commere
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
            services.AddMvc();
            services.AddControllersWithViews();
            services.AddOptions();
            services.AddDbContext<Mycontext>(options =>
            options.UseSqlServer(Configuration["Data:Defat:ConnectionString"]));
            services.AddIdentity<Customer, ApplicationRole>()
                .AddEntityFrameworkStores<Mycontext>()
                .AddDefaultTokenProviders();
            services.AddScoped<ICartegory, CartegoryRepository>();
            services.AddScoped<ICartitem, CartItemRepository>();
            services.AddScoped<IOder, OrderRepository>();
            services.AddScoped<IOderLine, OrderLineRepository>();
            services.AddScoped<IPicture, PictureRepository>();
            services.AddScoped<IProduct, ProductRepository>();
            services.AddScoped<ISubCategory, SubCategoryRepository>();
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
            app.UseSession();
            
            app.UseAuthentication();
            /*  _ = app.UseStaticFiles(new StaticFileOptions()
              {
                  FileProvider = new PhysicalFileProvider(
                      Path.Combine(Dictionary<GetCurrentDirectory,>)),
                  RequestPath = new PathString("/client")
              });*/

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
