using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.Controllers;

[AllowAnonymous]
public class BlogsController : Controller
{
    private readonly IBlogService _blogService;
    public BlogsController(IBlogService blogService)
    {
        _blogService = blogService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult BlogRead(int id, int? writerId)
    {
        var blog = _blogService.GetById(id);
        ViewBag.BlogId = blog.BlogId;
        ViewBag.WriterId = writerId.Value;
        return View();
    }

}