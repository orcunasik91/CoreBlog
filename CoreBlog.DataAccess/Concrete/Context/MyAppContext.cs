using CoreBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CoreBlog.DataAccess.Concrete.Context;
public class MyAppContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=CoreBlogDb;User ID=sa;Password=Password1");
    }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Writer> Writers { get; set; }
    public DbSet<NewsLetter> NewsLetters { get; set; }
}