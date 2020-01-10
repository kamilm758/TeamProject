using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamProject.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FormGenerator.Models;
using TeamProject.Models;

namespace TeamProject
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(
                    "Host=projekt1920.cakejnzadj5u.us-east-1.rds.amazonaws.com;Database=postgres;Username=postgres;Password=projekt.pb19_20"));
            services.AddDefaultIdentity<MyUser>()
                .AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddScoped<FormGeneratorContext>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
private async Task CreateRoles(IServiceProvider serviceProvider)
{
    //adding custom roles
    var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var UserManager = serviceProvider.GetRequiredService<UserManager<MyUser>>();
    string[] roleNames = { "Admin", "Manager", "Member" };
    IdentityResult roleResult;
​
            foreach (var roleName in roleNames)
    {
        //creating the roles and seeding them to the database
        var roleExist = await RoleManager.RoleExistsAsync(roleName);
        if (!roleExist)
        {
            roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
        }
    }
​
            //creating a super user who could maintain the web app
            var poweruser = new MyUser
            {
                UserName = "TestowyAdmin",
                Email = "email@email.com"
            };
​
            string UserPassword = "Daniel.98";
            var _user = await UserManager.FindByEmailAsync("email@email.com");
​
            if (_user == null)
    {
        var createPowerUser = await UserManager.CreateAsync(poweruser, UserPassword);
        if (createPowerUser.Succeeded)
        {
            //here we tie the new user to the "Admin" role 
            await UserManager.AddToRoleAsync(poweruser, "Admin");
​
                    }
    }
}
