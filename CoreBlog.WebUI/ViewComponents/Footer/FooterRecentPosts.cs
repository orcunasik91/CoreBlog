using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.Footer;
public class FooterRecentPosts : ViewComponent
{
    private readonly IBlogService _blogService;

    public FooterRecentPosts(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public IViewComponentResult Invoke()
    {
        var recentPosts = _blogService.GetRecentBlogs();
        return View(recentPosts);
    }
}