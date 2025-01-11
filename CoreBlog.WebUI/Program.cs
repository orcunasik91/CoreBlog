using CoreBlog.Business.Abstract;
using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.DataAccess.Concrete.Context;
using CoreBlog.DataAccess.Concrete.Repositories.EntityFramework;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace CoreBlog.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<MyAppContext>();
            builder.Services.AddScoped<IBlogDal, EfBlogRepository>();
            builder.Services.AddScoped<IBlogService, BlogManager>();
            builder.Services.AddScoped<ICommentDal, EfCommentRepository>();
            builder.Services.AddScoped<ICommentService, CommentManager>();
            builder.Services.AddScoped<ICategoryDal, EfCategoryRepository>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();
            builder.Services.AddScoped<IWriterDal, EfWriterRepository>();
            builder.Services.AddScoped<IWriterService, WriterManager>();
            builder.Services.AddScoped<INewsLetterDal, EfNewsLetterRepository>();
            builder.Services.AddScoped<INewsLetterService, NewsLetterManager>();
            builder.Services.AddScoped<IAboutDal, EfAboutRepository>();
            builder.Services.AddScoped<IAboutService, AboutManager>();
            builder.Services.AddScoped<IContactDal, EfContactRepository>();
            builder.Services.AddScoped<IContactService, ContactManager>();

            builder.Services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
            builder.Services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(cookie =>
                {
                    cookie.LoginPath = "/Login/Index";
                });
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/Login/Index";
                options.SlidingExpiration = true;
            });

            WebApplication app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Blogs}/{action=Index}/{id?}");

            app.Run();
        }
    }
}