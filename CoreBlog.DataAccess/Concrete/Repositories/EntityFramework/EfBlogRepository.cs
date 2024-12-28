using CoreBlog.DataAccess.Abstract;
using CoreBlog.DataAccess.Concrete.Context;
using CoreBlog.Entities.Concrete;
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
}