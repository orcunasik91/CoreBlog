using CoreBlog.DataAccess.Abstract;
using CoreBlog.DataAccess.Concrete.Context;
using CoreBlog.Entities.Concrete;
using CoreBlog.Entities.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CoreBlog.DataAccess.Concrete.Repositories.EntityFramework;
public class EfBlogRepository : BaseEntityRepository<Blog>, IBlogDal
{
    public List<Blog> GetBlogsByCategory()
    {
        using (MyAppContext context = new() )
        {
            return context.Blogs.Include(b => b.Category).ToList();
        }
    }

    public List<CategoriesWithBlogCountsDto> GetCategoriesWithBlogCounts()
    {
        using (MyAppContext context = new())
        {
            var result = context.Categories
                .Select(
                category => new CategoriesWithBlogCountsDto
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                    BlogCount = context.Blogs.Count(blog => blog.CategoryId == category.CategoryId)
                }).ToList();
            return result;
        }
    }

    public List<Blog> GetRecentBlogs()
    {
        using (MyAppContext context = new())
        {
            return context.Blogs.OrderByDescending(blog => blog.BlogId).Take(2).ToList();
        }
    }
}