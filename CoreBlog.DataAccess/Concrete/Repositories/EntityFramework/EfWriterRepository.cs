using CoreBlog.DataAccess.Abstract;
using CoreBlog.Entities.Concrete;

namespace CoreBlog.DataAccess.Concrete.Repositories.EntityFramework;
public class EfWriterRepository : BaseEntityRepository<Writer>, IWriterDal
{
}