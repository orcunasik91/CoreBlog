using CoreBlog.Business.Abstract;
using CoreBlog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;
public class BlogsController : Controller
{
    private readonly IBlogService _blogService;
    private readonly ICommentService _commentService;
    public BlogsController(IBlogService blogService, ICommentService commentService)
    {
        _blogService = blogService;
        _commentService = commentService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult BlogRead(int id)
    {
        ViewBag.BlogId = id;
        return View();
    }

}