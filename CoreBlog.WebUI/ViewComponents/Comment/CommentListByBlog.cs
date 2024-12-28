using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.Comment;
public class CommentListByBlog : ViewComponent
{
    private readonly ICommentService _commentService;

    public CommentListByBlog(ICommentService commentService)
    {
        _commentService = commentService;
    }

    public IViewComponentResult Invoke(int id)
    {
        var comments = _commentService.GetCommentsByBlog(id);
        return View(comments);
    }
}