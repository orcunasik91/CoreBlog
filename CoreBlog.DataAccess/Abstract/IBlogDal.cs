using CoreBlog.Entities.Concrete;

namespace CoreBlog.DataAccess.Abstract;
public interface IBlogDal : IBaseEntityDal<Blog>
{
    List<Blog> GetBlogsByCategory();
}