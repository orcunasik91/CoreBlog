using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.Blog;
public class BlogDetails : ViewComponent
{
    private readonly IBlogService _blogService;

    public BlogDetails(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public IViewComponentResult Invoke(int id)
    {
        ViewData["BlogId"] = id;
        var blogDetail = _blogService.GetById(id);
        return View(blogDetail);
    }
}