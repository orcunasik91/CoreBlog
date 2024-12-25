using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entities.Concrete;

namespace CoreBlog.Business.Concrete;
public class AboutManager : IAboutService
{
    private readonly IAboutDal _aboutDal;

    public AboutManager(IAboutDal aboutDal)
    {
        _aboutDal = aboutDal;
    }

    public void Create(About entity)
    {
        _aboutDal.Insert(entity);
    }

    public void Delete(About entity)
    {
        _aboutDal.Delete(entity);
    }

    public About GetById(int id)
    {
        return _aboutDal.GetById(id);
    }

    public List<About> GetList()
    {
        return _aboutDal.GetAll();
    }

    public void Update(About entity)
    {
        _aboutDal.Update(entity);
    }
}