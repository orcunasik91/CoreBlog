using CoreBlog.Entities.Concrete;
using CoreBlog.Entities.Dtos;

namespace CoreBlog.Business.Abstract;
public interface IBlogService : IBaseEntityService<Blog>
{
    List<Blog> GetBlogListWithCategory();
    List<Blog> GetBlogsById(int id);
    List<Blog> GetBlogsByWriter(int writerId);
    List<Blog> GetBlogsWithCategoryByWriter(int writerId);
    List<Blog> GetRecentBlogs();
    List<CategoriesWithBlogCountsDto> GetCategoriesWithBlogCounts();
}