using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.Blog;
public class BlogsOfWriter : ViewComponent
{
    private readonly IBlogService _blogService;

    public BlogsOfWriter(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public IViewComponentResult Invoke(int writerId)
    {
        var blogs = _blogService.GetBlogsByWriter(writerId);
        return View(blogs);
    }
}
