using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entities.Concrete;

namespace CoreBlog.Business.Concrete;
public class WriterManager : IWriterService
{
    private readonly IWriterDal _writerDal;

    public WriterManager(IWriterDal writerDal)
    {
        _writerDal = writerDal;
    }

    public void Create(Writer entity)
    {
        _writerDal.Insert(entity);
    }

    public void Delete(Writer entity)
    {
        _writerDal.Delete(entity);
    }

    public Writer GetById(int id)
    {
        return _writerDal.GetById(id);
    }

    public List<Writer> GetList()
    {
        return _writerDal.GetAll();
    }

    public void Update(Writer entity)
    {
        _writerDal.Update(entity);
    }
}