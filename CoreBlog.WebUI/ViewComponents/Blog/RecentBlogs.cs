using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.Blog;
public class RecentBlogs : ViewComponent
{
    private readonly IBlogService _blogService;

    public RecentBlogs(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public IViewComponentResult Invoke()
    {
        var recentBlogs = _blogService.GetRecentBlogs();
        return View(recentBlogs);
    }
}