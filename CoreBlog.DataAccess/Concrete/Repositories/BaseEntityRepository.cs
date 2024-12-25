using CoreBlog.DataAccess.Abstract;
using CoreBlog.DataAccess.Concrete.Context;

namespace CoreBlog.DataAccess.Concrete.Repositories;
public class BaseEntityRepository<TEntity> : IBaseEntityDal<TEntity> where TEntity : class, new()
{
    public void Delete(TEntity entity)
    {
        using (MyAppContext context = new())
        {
            context.Remove(entity);
            context.SaveChanges();
        }
    }

    public List<TEntity> GetAll()
    {
        using (MyAppContext context = new())
        {
            return context.Set<TEntity>().ToList();
        }
    }

    public TEntity GetById(int id)
    {
        using (MyAppContext context = new())
        {
            return context.Set<TEntity>().Find(id);
        }
    }

    public void Insert(TEntity entity)
    {
        using (MyAppContext context = new())
        {
            context.Add(entity);
            context.SaveChanges();
        }
    }

    public void Update(TEntity entity)
    {
        using (MyAppContext context = new())
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}