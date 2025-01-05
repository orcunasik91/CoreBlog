using CoreBlog.Entities.Concrete;
using CoreBlog.Entities.Dtos;

namespace CoreBlog.DataAccess.Abstract;
public interface IBlogDal : IBaseEntityDal<Blog>
{
    List<Blog> GetBlogsByCategory();
    List<Blog> GetRecentBlogs();
    List<CategoriesWithBlogCountsDto> GetCategoriesWithBlogCounts();
}