using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using KaloriNetProject.BusinessLayer.Abstract;
using KaloriNetProject.BusinessLayer.Concrete;
using KaloriNetProject.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUi.EmailServices;

namespace KaloriNetProject
{
    public class Startup
    {

       
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.AddDbContext<ApplicationIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders(); // parala reset islemi  yaptiginda kullaniciya benzersiz bir token goondermek icin kulaniyoruz

            services.Configure<IdentityOptions>(options =>
            {
                //sifre kismi
                //options.Password.RequireDigit = true;
                //options.Password.RequireLowercase = true; // sifrede kucuk bir karekter de ister
                //options.Password.RequiredLength = 2; // minimum karekter miktarini belirler
                
                //options.Lockout.MaxFailedAccessAttempts = 5;// parolayi yanlis girme hakkini belirler
                 options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
            });
            

            services.ConfigureApplicationCookie( options =>{


                options.LoginPath = "/account/login";
                options.LogoutPath = "/account/logout";
                options.AccessDeniedPath = "/account/accessdenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
                options.SlidingExpiration = true;

                options.Cookie = new CookieBuilder
                {

                    HttpOnly = true,
                    Name = "KAloriNet.Security",
                    SameSite = SameSiteMode.Strict
                };


            });

            services.AddScoped<IProductDal, EfProductRepository>();
            services.AddScoped<ICategoryDal, EfCategoryRepository>();
              services.AddScoped<ICartDal, EfCartRepository>();
              services.AddScoped<IRecordDal, EfRecordRepository>();


            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<IRecordService, RecordManager>();

            services.AddTransient<IEmailSender, EmailSender>();
            
            services.AddControllersWithViews();



            services.AddMvc(Config =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser()
                .Build();

                Config.Filters.Add(new AuthorizeFilter(policy));

            });
            services.AddMvc();
            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x => {

                    x.LoginPath = "/Login/Index";
                }

                );



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
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=AnaSayfa}/{action=Index}/{id?}");// buradaki home u Anaseyfa yaptin bir sikintii cikarsa
            });
        }
    }
}
