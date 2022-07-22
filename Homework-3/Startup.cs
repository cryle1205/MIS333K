using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

//TODO: (For HW1 and HW2) Delete the below statements.
//TODO: (For HW3 and beyond) Uncomment these statements.
using Microsoft.AspNetCore.Identity;


//TODO: (For HW1) Delete the below statement. 
//TODO: (For HW2 and beyond) Update this using statement to reference your project 
using Le_Crystal_HW3.Models;


//TODO: (For HW1 and HW2) Delete the below statement.
//TODO: (For HW3 and beyond) Update this using statement to reference your project 
using Le_Crystal_HW3.DAL;


//TODO: Make this namespace match your project - be sure to remove the []
namespace Le_Crystal_HW3
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //NOTE: This adds the MVC engine and Razor code
            services.AddControllersWithViews();

            //TODO: (For HW3 and beyond) Add a connection string here once you have created it on Azure
            var connectionString = "Server=tcp:sp22lecrystalhw3.database.windows.net,1433;Initial Catalog=sp22lecrystalhw3;" +
                "Persist Security Info=False;User ID=MISAdmin;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;" +
                "TrustServerCertificate=False;Connection Timeout=30;";  //paste your connection string from Azure in between the quotes.
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
            services.AddMvc();

            //TODO: (For HW3 and beyond) Uncomment this line once you have your connection string
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

            
        }

        public void Configure(IApplicationBuilder app)
        {
            //These lines allow you to see more detailed error messages
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();      

            //This line allows you to use static pages like style sheets and images
            app.UseStaticFiles();

            //This marks the position in the middleware pipeline where a routing decision
            //is made for a URL.
            app.UseRouting();

            //This allows the data annotations for currency to work on Macs
            app.Use(async (context, next) =>
            {
                CultureInfo.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
                CultureInfo.CurrentUICulture = CultureInfo.CurrentCulture;

                await next.Invoke();
            });

            
            
            //This method maps the controllers and their actions to a patter for
            //requests that's known as the default route. This route identifies
            //the Home controller as the default controller and the Index() action
            //method as the default action. The default route also identifies a 
            //third segment of the URL that's a parameter named id.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }   
}