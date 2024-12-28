using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entities.Concrete;

namespace CoreBlog.Business.Concrete;
public class BlogManager : IBlogService
{
    private readonly IBlogDal _blogDal;

    public BlogManager(IBlogDal blogDal)
    {
        _blogDal = blogDal;
    }

    public void Create(Blog entity)
    {
        _blogDal.Insert(entity);
    }

    public void Delete(Blog entity)
    {
        _blogDal.Delete(entity);
    }

    public List<Blog> GetBlogListWithCategory()
    {
        return _blogDal.GetBlogsByCategory();
    }

    public List<Blog> GetBlogsById(int id)
    {
        return _blogDal.GetAll(b => b.BlogId == id);
    }

    public Blog GetById(int id)
    {
        return _blogDal.GetById(id);
    }

    public List<Blog> GetList()
    {
        return _blogDal.GetAll();
    }

    public void Update(Blog entity)
    {
        _blogDal.Update(entity);
    }
}