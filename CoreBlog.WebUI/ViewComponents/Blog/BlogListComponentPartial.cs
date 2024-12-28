using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.Blog;
public class BlogListComponentPartial : ViewComponent
{
    private readonly IBlogService _blogService;

    public BlogListComponentPartial(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public IViewComponentResult Invoke()
    {
        var blogs = _blogService.GetBlogListWithCategory();
        return View(blogs);
    }
}