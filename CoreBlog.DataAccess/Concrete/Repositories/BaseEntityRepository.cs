using CoreBlog.DataAccess.Abstract;
using CoreBlog.DataAccess.Concrete.Context;
using System.Linq.Expressions;

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

    public TEntity GetById(int id)
    {
        using (MyAppContext context = new())
        {
            return context.Set<TEntity>().Find(id);
        }
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
    {
        using (MyAppContext context = new())
        {
            return filter == null
                ? new List<TEntity>(context.Set<TEntity>().ToList())
                : new List<TEntity>(context.Set<TEntity>().Where(filter).ToList());
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