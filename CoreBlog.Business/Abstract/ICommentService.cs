﻿using CoreBlog.Entities.Concrete;

namespace CoreBlog.Business.Abstract;
public interface ICommentService : IBaseEntityService<Comment>
{
    List<Comment> GetCommentsByBlog(int id);
}