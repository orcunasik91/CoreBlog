using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entities.Concrete;

namespace CoreBlog.Business.Concrete;
public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Create(Category entity)
    {
        _categoryDal.Insert(entity);
    }

    public void Delete(Category entity)
    {
        _categoryDal.Delete(entity);
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public List<Category> GetList()
    {
        return _categoryDal.GetAll();
    }

    public void Update(Category entity)
    {
        _categoryDal.Update(entity);
    }
}