using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;
using TigrisTech.Entities.Concrete.JsonTable;
using TigrisTech.Mvc.AutoMapper.Profiles;
using TigrisTech.MvcUI.Helpers.Abstract;
using TigrisTech.MvcUI.Helpers.Concrete;
using TigrisTech.Services.AutoMapper.Profiles;
using TigrisTech.Services.Extensions;
using TigrisTech.Shared.Utilities.Extensions;
using TigrisTecH.MvcUI.Filters;

namespace TigrisTech.MvcUI
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
            services.AddTransient<IImageHelper, ImageHelper>();
            services.AddSingleton(provider => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new UserProfile(provider.GetService<IImageHelper>()));
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new ArticleProfile());
                cfg.AddProfile(new ViewModelsProfile(provider.GetService<IImageHelper>()));
                cfg.AddProfile(new CommentProfile());
                cfg.AddProfile(new SliderProfile());
                cfg.AddProfile(new GaleryProfile());
            }).CreateMapper());

            services.Configure<AboutUsPageInfo>(Configuration.GetSection("AboutUsPageInfo"));
            services.Configure<ContactPageInfo>(Configuration.GetSection("ContactPageInfo"));
            services.Configure<WebsiteInfo>(Configuration.GetSection("WebsiteInfo"));
            services.Configure<SmtpSetting>(Configuration.GetSection("SmtpSettings"));

            services.Configure<ArticleRightSideBarWidgetOptions>(Configuration.GetSection("ArticleRighSideBarWidgetOptions"));
            services.ConfigureWritable<AboutUsPageInfo>(Configuration.GetSection("AboutUsPageInfo"));
            services.ConfigureWritable<ContactPageInfo>(Configuration.GetSection("ContactPageInfo"));
            services.ConfigureWritable<WebsiteInfo>(Configuration.GetSection("WebsiteInfo"));
            services.ConfigureWritable<SmtpSetting>(Configuration.GetSection("SmtpSettings"));
            services.ConfigureWritable<ArticleRightSideBarWidgetOptions>(Configuration.GetSection("ArticleRighSideBarWidgetOptions"));

            services.AddControllersWithViews(options =>
            {
                options.ModelBindingMessageProvider
                .SetValueMustNotBeNullAccessor(value => "Bu alan boş geçilmemelidir.");
                options.Filters.Add<MvcExceptionFilter>();
            }).AddRazorRuntimeCompilation().AddJsonOptions(opt =>
            {
                opt.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            }).AddNToastNotifyToastr();
            services.AddSession();
            services.LoadMyServices(connectionString: Configuration.GetConnectionString("AbdullahDev"));
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Admin/Auth/Login");
                options.LogoutPath = new PathString("/Admin/Auth/Logout");
                options.Cookie = new CookieBuilder
                {
                    Name = "TigrisContext",
                    HttpOnly = true, //css saldırısını önlemek
                    SameSite = SameSiteMode.Strict, //csrf saldırısını önlemek için Strict en güvenlidir.
                    SecurePolicy = CookieSecurePolicy.SameAsRequest, //CookieSecurePolicy.Always test aşaması için SameAsRequest kullanık
                };
                options.SlidingExpiration = true; //zaman tanıma
                options.ExpireTimeSpan = System.TimeSpan.FromDays(7);//7 gün boyunca bu kullanıcı tekrardan sisteme giriş yapması gerekmeyecek
                options.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied"); //izni olmadan giriş yapmış nereye yönelecek.

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            app.UseStatusCodePagesWithReExecute("/Page/Error", "?code={0}");

            app.UseSession();
            app.UseStaticFiles();//resimler, css ,javascript dosyaları olabilir

            app.UseRouting();
            app.UseAuthentication();//kullanıcı girişi
            app.UseAuthorization();//yetki kontrolü
            app.UseNToastNotify();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "Admin",
                    areaName: "Admin",
                    pattern: "Admin/{controller=Auth}/{action=Login}/{id?}"
                    );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
                endpoints.MapControllerRoute(
                   name: "article",
                   pattern: "{title}/{articleId}",
                   defaults: new { controller = "Article", action = "Detail" }
                   );
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
