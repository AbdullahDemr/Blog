
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using TigrisTech.Data.Abstract;
using TigrisTech.Data.Concrete;
using TigrisTech.Data.Concrete.EntityFramework.Contexts;
using TigrisTech.Entities.Concrete.UserTable;
using TigrisTech.Services.Abstract;
using TigrisTech.Services.Concrete;

namespace TigrisTech.Services.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection LoadMyServices(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<TigrisContext>(options => options.UseSqlServer(
                connectionString/*, o => o.CommandTimeout(99999999)*/).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

            serviceCollection.AddIdentity<User, Role>(options =>
            {
                //User Password Options
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 5;
                options.Password.RequiredUniqueChars = 0;//en az iki özel karakter
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                //User Username and Email Options
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<TigrisContext>()
            .AddDefaultTokenProviders();
            serviceCollection.Configure<SecurityStampValidatorOptions>(options =>
            {
                options.ValidationInterval = TimeSpan.FromMinutes(15)/*TimeSpan.Zero*/;
            });
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            //Blog
            serviceCollection.AddScoped<ICategoryService, CategoryManager>();
            serviceCollection.AddScoped<IArticleService, ArticleManager>();
            serviceCollection.AddScoped<ICommentService, CommentManager>();
            //Site
            serviceCollection.AddScoped<IProfilService, ProfilManager>();
            serviceCollection.AddScoped<ISliderService, SliderManager>();
            serviceCollection.AddScoped<IGaleryService, GaleryManager>();
            serviceCollection.AddScoped<IDoctorService, DoctorManager>();


            serviceCollection.AddSingleton<IMailService, MailManager>();
            return serviceCollection;
        }
    }
}
