using CoreBlog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.WebUI.ViewComponents.Category;
public class CategoryList : ViewComponent
{
    private readonly ICategoryService _categoryService;

    public CategoryList(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public IViewComponentResult Invoke()
    {
        var categories = _categoryService.GetList();
        return View(categories);
    }
}