using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.Category;
public class CategoryList : ViewComponent
{
    private readonly IBlogService _blogService;

    public CategoryList(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public IViewComponentResult Invoke()
    {
        var categoryWithBlogCounts = _blogService.GetCategoriesWithBlogCounts();
        return View(categoryWithBlogCounts);
    }
}