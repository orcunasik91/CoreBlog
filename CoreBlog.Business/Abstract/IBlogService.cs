using CoreBlog.Entities.Concrete;

namespace CoreBlog.Business.Abstract;
public interface IBlogService : IBaseEntityService<Blog>
{
    List<Blog> GetBlogListWithCategory();
    List<Blog> GetBlogsById(int id);
}