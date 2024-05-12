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
using Microsoft.EntityFrameworkCore;
using OnlineShopCMS.Data;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
using OnlineShopCMS.Services;
using OnlineShopCMS.Repositories;

=======
using OnlineShopCMS.Models;
using OnlineShopCMS.Services;
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0

namespace OnlineShopCMS
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
<<<<<<< HEAD
            services.AddScoped<IPromotionService, PromotionService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IPromotionRepository, PromotionRepository>();


            services.AddDbContext<OnlineShopContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

           

            services.AddScoped<OrderService>();


=======

            services.AddDbContext<OnlineShopContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("OnlineShopContext")));
            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));

            services.AddTransient<IMailService, MailService>();
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0

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

<<<<<<< HEAD

            app.UseAuthentication();
            app.UseAuthorization();
=======
            app.UseAuthentication();
            app.UseAuthorization();

>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
<<<<<<< HEAD
                // Add a route for ShippingController
                endpoints.MapControllerRoute(
                    name: "shipping",
                    pattern: "{controller=Shipping}/{action=Download}/{orderId?}");
            });


        }

    }
}
=======
            });
        }
    }
}
>>>>>>> 6c1fd4ee0d5dbde6c6b3ed2f1e2922a5860308c0
