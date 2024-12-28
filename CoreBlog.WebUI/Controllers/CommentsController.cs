using CoreBlog.Business.Abstract;
using CoreBlog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class CommentsController : Controller
{
    private readonly ICommentService _commentService;

    public CommentsController(ICommentService commentService)
    {
        _commentService = commentService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddComment()
    {
        return PartialView();
    }
    [HttpPost]
    public IActionResult AddComment(Comment comment)
    {
        comment.CreatedDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MMMM-yyyy"));
        comment.IsActive = true;
        _commentService.Create(comment);
        return RedirectToAction("Index","Blogs");
    }
}