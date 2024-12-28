using CoreBlog.Business.Abstract;
using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entities.Concrete;

namespace CoreBlog.Business.Concrete;
public class CommentManager : ICommentService
{
    private readonly ICommentDal _commentDal;

    public CommentManager(ICommentDal commentDal)
    {
        _commentDal = commentDal;
    }

    public void Create(Comment entity)
    {
        _commentDal.Insert(entity);
    }

    public void Delete(Comment entity)
    {
        _commentDal.Delete(entity);
    }

    public Comment GetById(int id)
    {
        return _commentDal.GetById(id);
    }

    public List<Comment> GetCommentsByBlog(int id)
    {
        return _commentDal.GetAll(c => c.BlogId == id);
    }

    public List<Comment> GetList()
    {
        return _commentDal.GetAll();
    }

    public void Update(Comment entity)
    {
        _commentDal.Update(entity);
    }
}