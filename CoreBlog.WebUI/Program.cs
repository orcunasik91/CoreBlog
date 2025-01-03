using CoreBlog.Business.Abstract;
using CoreBlog.Business.Concrete;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.DataAccess.Concrete.Context;
using CoreBlog.DataAccess.Concrete.Repositories.EntityFramework;

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

            WebApplication app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Blogs}/{action=Index}/{id?}");

            app.Run();
        }
    }
}