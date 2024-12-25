using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entities.Concrete;

namespace CoreBlog.Business.Concrete;
public class ContactManager : IContactService
{
    private readonly IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public void Create(Contact entity)
    {
        _contactDal.Insert(entity);
    }

    public void Delete(Contact entity)
    {
        _contactDal.Delete(entity);
    }

    public Contact GetById(int id)
    {
        return _contactDal.GetById(id);
    }

    public List<Contact> GetList()
    {
        return _contactDal.GetAll();
    }

    public void Update(Contact entity)
    {
        _contactDal.Update(entity);
    }
}