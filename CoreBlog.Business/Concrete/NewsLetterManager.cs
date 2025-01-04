using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entities.Concrete;

namespace CoreBlog.Business.Concrete;
public class NewsLetterManager : INewsLetterService
{
    private readonly INewsLetterDal _newsLetterDal;

    public NewsLetterManager(INewsLetterDal newsLetterDal)
    {
        _newsLetterDal = newsLetterDal;
    }

    public void Create(NewsLetter entity)
    {
        _newsLetterDal.Insert(entity);
    }

    public void Delete(NewsLetter entity)
    {
        _newsLetterDal.Delete(entity);
    }

    public NewsLetter GetById(int id)
    {
        return _newsLetterDal.GetById(id);
    }

    public List<NewsLetter> GetList()
    {
        return _newsLetterDal.GetAll();
    }

    public void Update(NewsLetter entity)
    {
        _newsLetterDal.Update(entity);
    }
}