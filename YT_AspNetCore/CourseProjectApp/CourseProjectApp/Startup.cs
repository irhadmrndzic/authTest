using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseProjectApp.DATA;
using CourseProjectApp.EntityModel;
using CourseProjectApp.Models;
using CourseProjectApp.Repository;
//using CourseProjectApp.Entities;
using CourseProjectApp.Services;
using CourseProjectApp.ViewComponents;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
namespace CourseProjectApp
{
    public class Startup
    {


        public Startup(IHostingEnvironment env)
        {    //Setujemo root folder aplikacije
            var builder = new ConfigurationBuilder()
                //Setujemo root folder aplikacije
                .SetBasePath(env.ContentRootPath)
                //Setujemo Json file sa konfiguracijom
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                //Ukoliko je environment drugog tipa
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            if (env.IsDevelopment())
            {
                builder.AddApplicationInsightsSettings(developerMode: true);
                 builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();

        }

        public IConfigurationRoot Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Dodavanje servisa bez konfigurisanja istih
            services.AddMvc();

            //Dodavanje Interfejsa i povezane klase
            //singleton - svi zahtjevi dobijaju isti objekat na koristenje
           // services.AddSingleton<IMyInjectedInterface, MyInjectedService>();

            //scoped
            //simuliraju se visestruki zahtjevi, kreira se novi objekat/servis  za svaki novi zahtjev prema servisu
          //  services.AddScoped<IMyInjectedInterface, MyInjectedService>();

            //transient
            //slicno kao i scoped
            services.AddTransient<IMyInjectedInterface, MyInjectedService>();
             

          services.AddDbContext<ProfileContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ProfileContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IEmailSend, MessageSend>();
            services.AddTransient<ISmsSend, MessageSend>();
           

            services.Configure<MessageSenderOptions>(Configuration); // kako bi mogli povuci options iz json filea- secrets

            services.AddAuthentication();

            services.AddTransient<IProfileRepository, ProfileRepository>();

            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,ILoggerFactory loggerFactory,ProfileContext context)
        {

            //Konfiguracija servisa dodanih u ConfigurServices kontejneru

            //logiranje razlicitih eventa u aplikaciji u konzolu ili prema windowsu
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //dodavanje debug logger koji se koristi za log  informacije 
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink(); //konekcija na visual studio preko browser linka
            }
            else
            {
                app.UseExceptionHandler("/Main/Error");
            }
     
            app.UseStaticFiles(); // omogućava css javascript jquery fajlove, sve unutar wwwroot foldera ce biti ukljuceno ovdje

            // poziva defaultnu rutu sa home kontrolerom, akcijom index i opcionalnim id-em
            // app.UseMvcWithDefaultRoute();

           // app.UseIdentity();
            
            app.UseAuthentication();
           

            app.UseMvc(routes=> 
            {
                routes.MapRoute(
                    name: "default",
                    template:"{controller=Main}/{action=Index}/{id?}"
                    );
            });

            Initializer.Seed(context); 
        }
    }
}
