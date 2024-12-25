namespace CoreBlog.Business.Abstract;
public interface IBaseEntityService<T> where T : class, new()
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    T GetById(int id);
    List<T> GetList();
}